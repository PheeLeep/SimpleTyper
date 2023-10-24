namespace SimpleTyper_WF
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            ReverseTypeCBox = new CheckBox();
            WaitTimeNUP = new NumericUpDown();
            label1 = new Label();
            ClearButton = new Button();
            StartStopButton = new Button();
            groupBox2 = new GroupBox();
            InputRTB = new RichTextBox();
            groupBox3 = new GroupBox();
            OutputRTB = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WaitTimeNUP).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ReverseTypeCBox);
            groupBox1.Controls.Add(WaitTimeNUP);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ClearButton);
            groupBox1.Controls.Add(StartStopButton);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // ReverseTypeCBox
            // 
            ReverseTypeCBox.AutoSize = true;
            ReverseTypeCBox.Location = new Point(132, 60);
            ReverseTypeCBox.Name = "ReverseTypeCBox";
            ReverseTypeCBox.Size = new Size(93, 19);
            ReverseTypeCBox.TabIndex = 4;
            ReverseTypeCBox.Text = "Reverse Type";
            ReverseTypeCBox.UseVisualStyleBackColor = true;
            // 
            // WaitTimeNUP
            // 
            WaitTimeNUP.Location = new Point(228, 31);
            WaitTimeNUP.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            WaitTimeNUP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WaitTimeNUP.Name = "WaitTimeNUP";
            WaitTimeNUP.Size = new Size(85, 23);
            WaitTimeNUP.TabIndex = 3;
            WaitTimeNUP.TextAlign = HorizontalAlignment.Center;
            WaitTimeNUP.Value = new decimal(new int[] { 100, 0, 0, 0 });
            WaitTimeNUP.ValueChanged += WaitTimeNUP_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 35);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Wait Time (ms):";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(33, 57);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // StartStopButton
            // 
            StartStopButton.Location = new Point(33, 32);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(75, 23);
            StartStopButton.TabIndex = 0;
            StartStopButton.Text = "Start";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(InputRTB);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 121);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Input Text Here";
            // 
            // InputRTB
            // 
            InputRTB.Dock = DockStyle.Fill;
            InputRTB.Location = new Point(3, 19);
            InputRTB.Name = "InputRTB";
            InputRTB.Size = new Size(339, 99);
            InputRTB.TabIndex = 1;
            InputRTB.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(OutputRTB);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 222);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(345, 253);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Output";
            // 
            // OutputRTB
            // 
            OutputRTB.Dock = DockStyle.Fill;
            OutputRTB.Location = new Point(3, 19);
            OutputRTB.Name = "OutputRTB";
            OutputRTB.ReadOnly = true;
            OutputRTB.Size = new Size(339, 231);
            OutputRTB.TabIndex = 0;
            OutputRTB.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(345, 475);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SimpleTyper Winforms";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WaitTimeNUP).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RichTextBox OutputRTB;
        private RichTextBox InputRTB;
        private Button StartStopButton;
        private Label label1;
        private Button ClearButton;
        private NumericUpDown WaitTimeNUP;
        private CheckBox ReverseTypeCBox;
    }
}