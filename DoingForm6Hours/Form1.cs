using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace DoingForm6Hours
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int bet;

        private void randomizeTimer(System.Timers.Timer timer, double interval, double offset)
        {
            double s = new Random().NextDouble() > 0.5 ? 1 : -1;
            double r = new Random().NextDouble();

            timer.Interval = interval + interval * offset * r * s;
        }

        private void randomizeTimers()
        {
            randomizeTimer(timer1, 200, 0.2);
            randomizeTimer(timer2, 100, 0.2);
            randomizeTimer(timer3, 50, 0.2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int balance = Int32.Parse(this.balance.Text);
            bet = (int) this.betSelector.Value;

            if (bet > balance)
            {
                MessageBox.Show("Ставка слишком большая", "Ставка слишком большая",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bet <= 0)
            {
                MessageBox.Show("Ставка слишком маленькая", "Ставка слишком маленькая",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            button1.Enabled = false;
            betSelector.Enabled = false;

            this.balance.Text = (balance - bet).ToString();

            rollTimer.Enabled = true;
            randomizeTimers();
            update = true;
        }

        private bool update = true;

        private int roll1 = new Random().Next(0, 10);

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            roll1 = roll1 == 9 ? 0 : roll1 + 1;
            if (update)
                label1.Text = roll1.ToString();
        }

        private int roll2 = new Random().Next(0, 10);

        private void timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            roll2 = roll2 == 9 ? 0 : roll2 + 1;
            if (update)
                label2.Text = roll2.ToString();
        }

        private int roll3 = new Random().Next(0, 10);

        private void timer3_Elapsed(object sender, ElapsedEventArgs e)
        {
            roll3 = roll3 == 9 ? 0 : roll3 + 1;
            if (update)
                label3.Text = roll3.ToString();
        }

        private void rollTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            update = false;
            rollTimer.Enabled = false;

            int v1 = int.Parse(label1.Text);
            int v2 = int.Parse(label2.Text);
            int v3 = int.Parse(label3.Text);

            float r1 = 0;
            float r2 = 0;

            if (v1 == v2 && v2 == v3)
            {
                r1 = 2;
                r2 = v1;
            }
            else if (v1 == v2 || v1 == v3)
            {
                r1 = 1;
                r2 = v1;
            }
            else if (v2 == v3)
            {
                r1 = 1;
                r2 = v2;
            }

            r2 = r2 == 7 ? 2 : r2 / 10;

            int r = (int) Math.Ceiling(bet * r1 * r2);

            balance.Text = (int.Parse(balance.Text) + r).ToString();

            button1.Enabled = true;
            betSelector.Enabled = true;
        }
    }
}