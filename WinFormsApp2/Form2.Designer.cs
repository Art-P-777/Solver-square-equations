namespace WinFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            splitContainer1 = new SplitContainer();
            coef_c = new TextBox();
            coef_b = new TextBox();
            coef_a = new TextBox();
            About_btn = new Button();
            Reset_btn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(5, 0, 5, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(coef_c);
            splitContainer1.Panel1.Controls.Add(coef_b);
            splitContainer1.Panel1.Controls.Add(coef_a);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(About_btn);
            splitContainer1.Panel2.Controls.Add(Reset_btn);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(398, 216);
            splitContainer1.SplitterDistance = 135;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // coef_c
            // 
            coef_c.Dock = DockStyle.Top;
            coef_c.Font = new Font("Segoe UI", 15F);
            coef_c.Location = new Point(0, 94);
            coef_c.Name = "coef_c";
            coef_c.PlaceholderText = "c :";
            coef_c.Size = new Size(398, 47);
            coef_c.TabIndex = 2;
            coef_c.KeyPress += coef_KeyPress;
            // 
            // coef_b
            // 
            coef_b.Dock = DockStyle.Top;
            coef_b.Font = new Font("Segoe UI", 15F);
            coef_b.Location = new Point(0, 47);
            coef_b.Name = "coef_b";
            coef_b.PlaceholderText = "b :";
            coef_b.Size = new Size(398, 47);
            coef_b.TabIndex = 1;
            coef_b.KeyPress += coef_KeyPress;
            // 
            // coef_a
            // 
            coef_a.Dock = DockStyle.Top;
            coef_a.Font = new Font("Segoe UI", 15F);
            coef_a.Location = new Point(0, 0);
            coef_a.Name = "coef_a";
            coef_a.PlaceholderText = "a :";
            coef_a.Size = new Size(398, 47);
            coef_a.TabIndex = 0;
            coef_a.KeyPress += coef_KeyPress;
            // 
            // About_btn
            // 
            About_btn.Image = (Image)resources.GetObject("About_btn.Image");
            About_btn.Location = new Point(307, 0);
            About_btn.Name = "About_btn";
            About_btn.Size = new Size(91, 80);
            About_btn.TabIndex = 2;
            About_btn.UseVisualStyleBackColor = true;
            About_btn.Click += About_btn_Click;
            // 
            // Reset_btn
            // 
            Reset_btn.Font = new Font("Segoe UI", 1F);
            Reset_btn.Image = (Image)resources.GetObject("Reset_btn.Image");
            Reset_btn.Location = new Point(208, 0);
            Reset_btn.Name = "Reset_btn";
            Reset_btn.Size = new Size(105, 80);
            Reset_btn.TabIndex = 1;
            Reset_btn.UseVisualStyleBackColor = true;
            Reset_btn.Click += Reset_btn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(5, 0, 5, 0);
            button1.Name = "button1";
            button1.Size = new Size(210, 80);
            button1.TabIndex = 0;
            button1.Text = "Решить уравнение";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(398, 216);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Margin = new Padding(5, 0, 5, 0);
            MaximizeBox = false;
            Name = "Form2";
            ShowIcon = false;
            Text = "Решатель квадратных уравнений";
            TopMost = true;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button1;
        private TextBox coef_c;
        private TextBox coef_b;
        private TextBox coef_a;
        private Button About_btn;
        private Button Reset_btn;
    }
}