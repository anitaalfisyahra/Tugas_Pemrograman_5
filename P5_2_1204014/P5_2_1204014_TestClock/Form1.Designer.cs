namespace P5_2_1204014_TestClock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.digitalCock1 = new P5_2_1204014.DigitalCock();
            this.UniversalTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digitalCock1
            // 
            this.digitalCock1.LocalTimerLabel_BackColor = System.Drawing.SystemColors.ControlLight;
            this.digitalCock1.Location = new System.Drawing.Point(122, 34);
            this.digitalCock1.Name = "digitalCock1";
            this.digitalCock1.Size = new System.Drawing.Size(150, 60);
            this.digitalCock1.TabIndex = 0;
            this.digitalCock1.Timer1_Enabled = true;
            this.digitalCock1.RaiseTimer1_Tick += new System.EventHandler(this.digitalCock1_RaiseTimer1_Tick);
            // 
            // UniversalTimeLabel
            // 
            this.UniversalTimeLabel.Location = new System.Drawing.Point(132, 122);
            this.UniversalTimeLabel.Name = "UniversalTimeLabel";
            this.UniversalTimeLabel.Size = new System.Drawing.Size(131, 23);
            this.UniversalTimeLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Universal Time";
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(151, 187);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(75, 23);
            this.StartStopButton.TabIndex = 4;
            this.StartStopButton.Text = "Start/Stop";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UniversalTimeLabel);
            this.Controls.Add(this.digitalCock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private P5_2_1204014.DigitalCock digitalCock1;
        private System.Windows.Forms.Label UniversalTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartStopButton;
    }
}

