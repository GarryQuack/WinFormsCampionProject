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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roobert", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 320);
            label2.Name = "label2";
            label2.Size = new Size(116, 16);
            label2.TabIndex = 2;
            label2.Text = "No Name Entered";
            label2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 285);
            textBox1.MaxLength = 128;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(387, 23);
            textBox1.TabIndex = 3;
            textBox1.WordWrap = false;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roobert", 15F, FontStyle.Bold);
            label1.Location = new Point(59, 258);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 4;
            label1.Text = "Enter a name:";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(464, 285);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Add Name";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(558, 285);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Print All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roobert", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 194);
            label3.Name = "label3";
            label3.Size = new Size(224, 44);
            label3.TabIndex = 7;
            label3.Text = "Start of Run:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roobert", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 393);
            label4.Name = "label4";
            label4.Size = new Size(210, 44);
            label4.TabIndex = 8;
            label4.Text = "End of Run:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(950, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 226);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(464, 493);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Add Name";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roobert", 15F, FontStyle.Bold);
            label5.Location = new Point(59, 466);
            label5.Name = "label5";
            label5.Size = new Size(142, 24);
            label5.TabIndex = 12;
            label5.Text = "Enter a name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(59, 493);
            textBox2.MaxLength = 128;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(387, 23);
            textBox2.TabIndex = 11;
            textBox2.WordWrap = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roobert", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(59, 528);
            label6.Name = "label6";
            label6.Size = new Size(116, 16);
            label6.TabIndex = 10;
            label6.Text = "No Name Entered";
            label6.Visible = false;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(558, 493);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 14;
            button4.Text = "Finish Race";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 20, 21);
            ClientSize = new Size(1264, 681);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "QuickTrack";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Button button3;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private Button button4;
    }
}
