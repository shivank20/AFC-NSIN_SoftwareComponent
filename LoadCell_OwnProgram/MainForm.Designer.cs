namespace LoadCell_OwnProgram
{
    partial class MainForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ResultsLab = new System.Windows.Forms.Label();
            this.ForceLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.StressOutput = new System.Windows.Forms.Label();
            this.StressLabel = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.InitializeButton = new System.Windows.Forms.Button();
            this.TimeOutput = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DispLabel = new System.Windows.Forms.Label();
            this.DispOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Lime;
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.StartButton.Location = new System.Drawing.Point(565, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(243, 77);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Red;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.StopButton.Location = new System.Drawing.Point(850, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(243, 77);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ResultsLab
            // 
            this.ResultsLab.AutoSize = true;
            this.ResultsLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.6F);
            this.ResultsLab.Location = new System.Drawing.Point(335, 146);
            this.ResultsLab.Name = "ResultsLab";
            this.ResultsLab.Size = new System.Drawing.Size(226, 57);
            this.ResultsLab.TabIndex = 2;
            this.ResultsLab.Text = "Force [N]";
            // 
            // ForceLabel
            // 
            this.ForceLabel.AutoSize = true;
            this.ForceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.6F);
            this.ForceLabel.Location = new System.Drawing.Point(364, 220);
            this.ForceLabel.Name = "ForceLabel";
            this.ForceLabel.Size = new System.Drawing.Size(88, 57);
            this.ForceLabel.TabIndex = 3;
            this.ForceLabel.Text = "[N]";
            this.ForceLabel.Click += new System.EventHandler(this.ForceLabel_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(50, 136);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(50, 199);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Location = new System.Drawing.Point(50, 264);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gauge Length [mm]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gauge Thickness [mm]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gauge Width [mm]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Strain Rate [1/s]";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 3;
            this.numericUpDown4.Location = new System.Drawing.Point(50, 328);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown4.TabIndex = 11;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // StressOutput
            // 
            this.StressOutput.AutoSize = true;
            this.StressOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.64286F);
            this.StressOutput.Location = new System.Drawing.Point(958, 146);
            this.StressOutput.Name = "StressOutput";
            this.StressOutput.Size = new System.Drawing.Size(307, 57);
            this.StressOutput.TabIndex = 12;
            this.StressOutput.Text = "Stress [MPa]";
            // 
            // StressLabel
            // 
            this.StressLabel.AutoSize = true;
            this.StressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.64286F);
            this.StressLabel.Location = new System.Drawing.Point(1031, 206);
            this.StressLabel.Name = "StressLabel";
            this.StressLabel.Size = new System.Drawing.Size(154, 57);
            this.StressLabel.TabIndex = 13;
            this.StressLabel.Text = "[MPa]";
            this.StressLabel.Click += new System.EventHandler(this.StressLabel_Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.Location = new System.Drawing.Point(50, 390);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown5.TabIndex = 14;
            this.numericUpDown5.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Acquisition Rate [Hz]";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.FileName = "data.csv";
            this.saveFileDialog1.Title = "Enter File Name Here";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // InitializeButton
            // 
            this.InitializeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InitializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.InitializeButton.Location = new System.Drawing.Point(309, 9);
            this.InitializeButton.Name = "InitializeButton";
            this.InitializeButton.Size = new System.Drawing.Size(205, 77);
            this.InitializeButton.TabIndex = 16;
            this.InitializeButton.Text = "Initialize";
            this.InitializeButton.UseVisualStyleBackColor = false;
            this.InitializeButton.Click += new System.EventHandler(this.InitializeButton_Click);
            // 
            // TimeOutput
            // 
            this.TimeOutput.AutoSize = true;
            this.TimeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.64286F);
            this.TimeOutput.Location = new System.Drawing.Point(1161, 9);
            this.TimeOutput.Name = "TimeOutput";
            this.TimeOutput.Size = new System.Drawing.Size(201, 57);
            this.TimeOutput.TabIndex = 17;
            this.TimeOutput.Text = "Time [s]";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.64286F);
            this.TimeLabel.Location = new System.Drawing.Point(1216, 76);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(78, 57);
            this.TimeLabel.TabIndex = 18;
            this.TimeLabel.Text = "[s]";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // DispLabel
            // 
            this.DispLabel.AutoSize = true;
            this.DispLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.64286F);
            this.DispLabel.Location = new System.Drawing.Point(414, 550);
            this.DispLabel.Name = "DispLabel";
            this.DispLabel.Size = new System.Drawing.Size(121, 57);
            this.DispLabel.TabIndex = 19;
            this.DispLabel.Text = "[um]";
            // 
            // DispOutput
            // 
            this.DispOutput.AutoSize = true;
            this.DispOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.64286F);
            this.DispOutput.Location = new System.Drawing.Point(283, 484);
            this.DispOutput.Name = "DispOutput";
            this.DispOutput.Size = new System.Drawing.Size(433, 57);
            this.DispOutput.TabIndex = 20;
            this.DispOutput.Text = "Displacement [um]";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1610, 820);
            this.Controls.Add(this.DispOutput);
            this.Controls.Add(this.DispLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeOutput);
            this.Controls.Add(this.InitializeButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.StressLabel);
            this.Controls.Add(this.StressOutput);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ForceLabel);
            this.Controls.Add(this.ResultsLab);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label ResultsLab;
        private System.Windows.Forms.Label ForceLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label StressOutput;
        private System.Windows.Forms.Label StressLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button InitializeButton;
        private System.Windows.Forms.Label TimeOutput;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DispLabel;
        private System.Windows.Forms.Label DispOutput;
    }
}