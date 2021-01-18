using System.Drawing;
using System.Windows.Forms;

namespace DoingForm6Hours
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.betSelector = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Timers.Timer();
            this.timer2 = new System.Timers.Timer();
            this.timer3 = new System.Timers.Timer();
            this.rollTimer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize) (this.betSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.rollTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto Black", 128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(64, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 236);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto Black", 128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(300, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 236);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto Black", 128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(565, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 236);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(477, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 53);
            this.label4.TabIndex = 3;
            this.label4.Text = "Баланс:";
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Roboto Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.balance.Location = new System.Drawing.Point(592, 405);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(100, 46);
            this.balance.TabIndex = 4;
            this.balance.Text = "100";
            // 
            // betSelector
            // 
            this.betSelector.Font = new System.Drawing.Font("Roboto Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.betSelector.Location = new System.Drawing.Point(592, 475);
            this.betSelector.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.betSelector.Name = "betSelector";
            this.betSelector.Size = new System.Drawing.Size(100, 43);
            this.betSelector.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.SynchronizingObject = this;
            this.timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.timer2_Elapsed);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 50D;
            this.timer3.SynchronizingObject = this;
            this.timer3.Elapsed += new System.Timers.ElapsedEventHandler(this.timer3_Elapsed);
            // 
            // rollTimer
            // 
            this.rollTimer.Interval = 10000D;
            this.rollTimer.SynchronizingObject = this;
            this.rollTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.rollTimer_Elapsed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.betSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.rollTimer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown betSelector;

        private System.Timers.Timer rollTimer;

        private System.Timers.Timer timer3;

        private System.Timers.Timer timer2;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.Label balance;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}