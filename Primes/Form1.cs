using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primes
{
    public partial class Form1 : Form
    {
        private ConcurrentQueue<ulong> primeQueue = new ConcurrentQueue<ulong>();
        private ulong target = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //start
            try
            {
                target = ulong.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                target = 1024;
            }

            textBox1.Text = "";
            startButton.Enabled = clearButton.Enabled = false;
            stopButton.Enabled = true;

            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int lastProgress = 0;
            BackgroundWorker worker = sender as BackgroundWorker;

            primeQueue.Enqueue(2);

            for (ulong now = 3; now <= target; now += 2)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                ulong end = (ulong) Math.Floor(Math.Sqrt(now));
                bool prime = true;
                for (ulong i = 3; i < end; i += 2)
                {
                    if (now % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    primeQueue.Enqueue(now);
                }

                int progress = (int) (100 * now / target);
                //if ((now % 10000 - 1) == 0)
                if (progress > lastProgress)
                {
                    lastProgress = progress;
                    worker.ReportProgress(progress);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;

            StringBuilder builder = new StringBuilder();
            ulong prime;
            ulong primeCount = 0;
            while (primeQueue.TryDequeue(out prime) && primeCount < 1000)
            {
                primeCount++;
                builder.Append(prime.ToString());
                builder.Append(" ");
            }

            textBox1.AppendText(builder.ToString());
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stopButton.Enabled = false;

            StringBuilder builder = new StringBuilder(primeQueue.Count * 2);
            ulong prime;
            while (primeQueue.TryDequeue(out prime))
            {
                builder.Append(prime.ToString());
                builder.Append(" ");
            }

            textBox1.AppendText(builder.ToString());

            startButton.Enabled = clearButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}