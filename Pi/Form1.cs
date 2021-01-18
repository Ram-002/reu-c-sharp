using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Pi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly CalcWorker[] workers = new CalcWorker[16];
        private readonly Thread[] threads = new Thread[16];
        private bool calculating = false;
        private ulong parts;
        private uint concurrency;
        private uint accuracy;

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!calculating)
                return;

            ulong progress = 0;
            for (uint i = 0; i < concurrency; i++)
            {
                progress += workers[i].getProgress();
            }

            progressBar.Value = (int) (progress * 10000 / parts);

            decimal result = 0;
            if (progress == parts)
            {
                for (uint i = 0; i < concurrency; i++)
                {
                    result += workers[i].getResult();
                }

                outputLabel.Text = (result * 4).ToString("n" + accuracy);

                calculating = false;
                calculateButton.Enabled = true;
                concurrencyInput.Enabled = true;
                accuracyInput.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (calculating)
                return;

            calculating = true;
            calculateButton.Enabled = false;
            concurrencyInput.Enabled = false;
            accuracyInput.Enabled = false;

            accuracy = (uint) this.accuracyInput.Value;
            concurrency = (uint) this.concurrencyInput.Value;
            parts = GetPartsForAccuracy((int) this.accuracyInput.Value);

            ulong segment = parts / concurrency;

            for (uint i = 0; i < concurrency; i++)
            {
                if (i < concurrency - 1)
                {
                    workers[i] = new CalcWorker(i * segment, (i + 1) * segment);
                }
                else
                {
                    workers[i] = new CalcWorker(segment * i, parts);
                }

                Thread thread = threads[i] = new Thread(workers[i].calc);
                thread.Priority = ThreadPriority.Lowest;
                thread.IsBackground = true;
                thread.Start();
            }
        }

        public ulong GetPartsForAccuracy(int accuracy)
        {
            ulong result = (ulong) Math.Pow(10, accuracy + 1);
            return result;
        }
    }

    public class CalcWorker
    {
        private ulong progress;
        private decimal result;

        private readonly ulong start;
        private readonly ulong end;

        public CalcWorker(ulong start, ulong end)
        {
            this.start = start;
            this.end = end;

            progress = 0;
            result = 0;
        }

        public void calc()
        {
            ulong progress = 0;
            decimal result = 0;

            for (ulong i = start; i < end; i++)
            {
                int sig = i % 2 == 0 ? 1 : -1;
                decimal frac = 2 * i + 1;


                result += sig / frac;
                progress++;

                if (i % 1_000_000 == 0)
                {
                    lock (this)
                    {
                        this.result = result;
                        this.progress = progress;
                    }
                }
            }

            lock (this)
            {
                this.result = result;
                this.progress = progress;
            }
        }


        public ulong getProgress()
        {
            lock (this)
            {
                return progress;
            }
        }

        public decimal getResult()
        {
            lock (this)
            {
                return result;
            }
        }
    }
}