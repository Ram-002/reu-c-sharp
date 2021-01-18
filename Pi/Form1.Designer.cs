
using System.Windows.Forms;

namespace Pi
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
            this.accuracyInput = new System.Windows.Forms.NumericUpDown();
            this.concurrencyInput = new System.Windows.Forms.NumericUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Timers.Timer();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.concurrencyLabel = new System.Windows.Forms.Label();
            this.accuracyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accuracyInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concurrencyInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // accuracyInput
            // 
            this.accuracyInput.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accuracyInput.Location = new System.Drawing.Point(117, 45);
            this.accuracyInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accuracyInput.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.accuracyInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.accuracyInput.Name = "accuracyInput";
            this.accuracyInput.Size = new System.Drawing.Size(117, 32);
            this.accuracyInput.TabIndex = 0;
            this.accuracyInput.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // concurrencyInput
            // 
            this.concurrencyInput.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.concurrencyInput.Location = new System.Drawing.Point(117, 7);
            this.concurrencyInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.concurrencyInput.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.concurrencyInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.concurrencyInput.Name = "concurrencyInput";
            this.concurrencyInput.Size = new System.Drawing.Size(117, 32);
            this.concurrencyInput.TabIndex = 0;
            this.concurrencyInput.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 83);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar.Maximum = 10000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(221, 27);
            this.progressBar.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Roboto Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(12, 116);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(222, 27);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Roboto Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.Location = new System.Drawing.Point(12, 146);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(222, 25);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "4";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // concurrencyLabel
            // 
            this.concurrencyLabel.AutoSize = true;
            this.concurrencyLabel.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.concurrencyLabel.Location = new System.Drawing.Point(12, 9);
            this.concurrencyLabel.Name = "concurrencyLabel";
            this.concurrencyLabel.Size = new System.Drawing.Size(79, 25);
            this.concurrencyLabel.TabIndex = 3;
            this.concurrencyLabel.Text = "Потоки";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accuracyLabel.Location = new System.Drawing.Point(12, 47);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(98, 25);
            this.accuracyLabel.TabIndex = 4;
            this.accuracyLabel.Text = "Точность";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 180);
            this.Controls.Add(this.accuracyLabel);
            this.Controls.Add(this.concurrencyLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.accuracyInput);
            this.Controls.Add(this.concurrencyInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.accuracyInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concurrencyInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label outputLabel;

        private System.Windows.Forms.Button calculateButton;

        private NumericUpDown accuracyInput;
        private NumericUpDown concurrencyInput;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Timers.Timer timer1;

        #endregion

        private Label accuracyLabel;
        private Label concurrencyLabel;
    }
}