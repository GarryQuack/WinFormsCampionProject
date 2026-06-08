namespace QuickTrack
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            FinishRunner = new Button();
            label5 = new Label();
            Input_End = new TextBox();
            label6 = new Label();
            ButtonFinishRace = new Button();
            TitleLabel = new Label();
            TimeKeeping = new Label();
            RaceStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            Time = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 417);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 24);
            label2.TabIndex = 2;
            label2.Text = "No Name Entered";
            label2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 358);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.MaxLength = 128;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(551, 31);
            textBox1.TabIndex = 3;
            textBox1.WordWrap = false;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label1.Location = new Point(83, 313);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 36);
            label1.TabIndex = 4;
            label1.Text = "Enter a name:";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(669, 358);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(111, 42);
            button1.TabIndex = 5;
            button1.Text = "Add Name";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(803, 358);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(111, 42);
            button2.TabIndex = 6;
            button2.Text = "Print All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(341, 64);
            label3.TabIndex = 7;
            label3.Text = "Start of Run:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 538);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(321, 64);
            label4.TabIndex = 8;
            label4.Text = "End of Run:";
            // 
            // FinishRunner
            // 
            FinishRunner.Font = new Font("Segoe UI", 9F);
            FinishRunner.ForeColor = SystemColors.ActiveCaptionText;
            FinishRunner.Location = new Point(669, 705);
            FinishRunner.Margin = new Padding(4, 5, 4, 5);
            FinishRunner.Name = "FinishRunner";
            FinishRunner.Size = new Size(111, 42);
            FinishRunner.TabIndex = 13;
            FinishRunner.Text = "End Runner";
            FinishRunner.UseVisualStyleBackColor = true;
            FinishRunner.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label5.Location = new Point(83, 660);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(211, 36);
            label5.TabIndex = 12;
            label5.Text = "Enter a name:";
            // 
            // Input_End
            // 
            Input_End.Location = new Point(90, 705);
            Input_End.Margin = new Padding(4, 5, 4, 5);
            Input_End.MaxLength = 128;
            Input_End.Name = "Input_End";
            Input_End.Size = new Size(551, 31);
            Input_End.TabIndex = 11;
            Input_End.WordWrap = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(90, 763);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(175, 24);
            label6.TabIndex = 10;
            label6.Text = "No Name Entered";
            label6.Visible = false;
            // 
            // ButtonFinishRace
            // 
            ButtonFinishRace.ForeColor = SystemColors.ActiveCaptionText;
            ButtonFinishRace.Location = new Point(803, 705);
            ButtonFinishRace.Margin = new Padding(4, 5, 4, 5);
            ButtonFinishRace.Name = "ButtonFinishRace";
            ButtonFinishRace.Size = new Size(111, 42);
            ButtonFinishRace.TabIndex = 14;
            ButtonFinishRace.Text = "Finish Race";
            ButtonFinishRace.UseVisualStyleBackColor = true;
            ButtonFinishRace.Click += ButtonFinishRace_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Roobert-TRIAL SemiBold", 47.9999962F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(17, 15);
            TitleLabel.Margin = new Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(549, 134);
            TitleLabel.TabIndex = 15;
            TitleLabel.Text = "QuickTrack";
            // 
            // TimeKeeping
            // 
            TimeKeeping.BackColor = Color.White;
            TimeKeeping.BorderStyle = BorderStyle.FixedSingle;
            TimeKeeping.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimeKeeping.ForeColor = Color.FromArgb(192, 0, 0);
            TimeKeeping.Location = new Point(1083, 43);
            TimeKeeping.Margin = new Padding(0);
            TimeKeeping.Name = "TimeKeeping";
            TimeKeeping.Size = new Size(642, 99);
            TimeKeeping.TabIndex = 16;
            TimeKeeping.Text = "Race has not started yet!";
            TimeKeeping.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RaceStart
            // 
            RaceStart.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RaceStart.ForeColor = SystemColors.ActiveCaptionText;
            RaceStart.Location = new Point(1226, 263);
            RaceStart.Margin = new Padding(4, 5, 4, 5);
            RaceStart.Name = "RaceStart";
            RaceStart.Size = new Size(367, 190);
            RaceStart.TabIndex = 17;
            RaceStart.Text = "Start Race!";
            RaceStart.UseVisualStyleBackColor = true;
            RaceStart.Click += RaceStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Time
            // 
            Time.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Time.Location = new Point(1343, 183);
            Time.Margin = new Padding(4, 0, 4, 0);
            Time.Name = "Time";
            Time.Size = new Size(140, 33);
            Time.TabIndex = 18;
            Time.Text = "00:00:00.0000";
            Time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 20, 21);
            ClientSize = new Size(1806, 1135);
            Controls.Add(Time);
            Controls.Add(RaceStart);
            Controls.Add(TimeKeeping);
            Controls.Add(TitleLabel);
            Controls.Add(ButtonFinishRace);
            Controls.Add(FinishRunner);
            Controls.Add(label5);
            Controls.Add(Input_End);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "QuickTrack";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Button FinishRunner;
        private Label label5;
        private TextBox Input_End;
        private Label label6;
        private Button ButtonFinishRace;
        private Label TitleLabel;
        private Label TimeKeeping;
        private Button RaceStart;
        private System.Windows.Forms.Timer timer1;
        private Label Time;
    }
}
