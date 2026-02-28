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
            Title = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Roobert", 27.7499962F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(215, 44);
            Title.TabIndex = 0;
            Title.Text = "QuickTrack";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 89);
            button1.Name = "button1";
            button1.Size = new Size(155, 53);
            button1.TabIndex = 1;
            button1.Text = "Add Runner";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.Font = new Font("Roobert", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roobert", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 154);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 2;
            label2.Text = "No Name Entered";
            label2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1264, 681);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(Title);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "QuickTrack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button button1;
        private Label label2;
    }
}
