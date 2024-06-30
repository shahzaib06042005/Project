namespace projectDashboard
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panelbar = new Panel();
            buttonschedule = new Button();
            buttonpersonaldetails = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panelhome = new Panel();
            labelhome = new Label();
            label2 = new Label();
            panelbar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelhome.SuspendLayout();
            SuspendLayout();
            // 
            // panelbar
            // 
            panelbar.BackColor = Color.FromArgb(11, 12, 16);
            panelbar.Controls.Add(buttonschedule);
            panelbar.Controls.Add(buttonpersonaldetails);
            panelbar.Controls.Add(panel2);
            panelbar.Dock = DockStyle.Left;
            panelbar.Location = new Point(0, 0);
            panelbar.Name = "panelbar";
            panelbar.Size = new Size(190, 522);
            panelbar.TabIndex = 0;
            // 
            // buttonschedule
            // 
            buttonschedule.Dock = DockStyle.Top;
            buttonschedule.FlatAppearance.BorderSize = 0;
            buttonschedule.FlatStyle = FlatStyle.Flat;
            buttonschedule.Font = new Font("Copperplate Gothic Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonschedule.ForeColor = Color.FromArgb(102, 252, 241);
            buttonschedule.Image = (Image)resources.GetObject("buttonschedule.Image");
            buttonschedule.Location = new Point(0, 150);
            buttonschedule.Name = "buttonschedule";
            buttonschedule.Size = new Size(190, 50);
            buttonschedule.TabIndex = 2;
            buttonschedule.Text = "Invigilation Schedule";
            buttonschedule.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonschedule.UseVisualStyleBackColor = true;
            buttonschedule.Click += buttonschedule_Click;
            // 
            // buttonpersonaldetails
            // 
            buttonpersonaldetails.Dock = DockStyle.Top;
            buttonpersonaldetails.FlatAppearance.BorderSize = 0;
            buttonpersonaldetails.FlatStyle = FlatStyle.Flat;
            buttonpersonaldetails.Font = new Font("Copperplate Gothic Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonpersonaldetails.ForeColor = Color.FromArgb(102, 252, 241);
            buttonpersonaldetails.Image = (Image)resources.GetObject("buttonpersonaldetails.Image");
            buttonpersonaldetails.Location = new Point(0, 100);
            buttonpersonaldetails.Name = "buttonpersonaldetails";
            buttonpersonaldetails.Size = new Size(190, 50);
            buttonpersonaldetails.TabIndex = 1;
            buttonpersonaldetails.Text = "Personal Details";
            buttonpersonaldetails.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonpersonaldetails.UseVisualStyleBackColor = true;
            buttonpersonaldetails.Click += buttonpersonaldetails_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 12, 16);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 100);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelhome
            // 
            panelhome.BackColor = Color.FromArgb(11, 12, 16);
            panelhome.Controls.Add(label2);
            panelhome.Controls.Add(labelhome);
            panelhome.Dock = DockStyle.Top;
            panelhome.Location = new Point(190, 0);
            panelhome.Name = "panelhome";
            panelhome.Size = new Size(636, 100);
            panelhome.TabIndex = 1;
            // 
            // labelhome
            // 
            labelhome.AutoSize = true;
            labelhome.Font = new Font("Georgia", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelhome.ForeColor = Color.FromArgb(102, 252, 241);
            labelhome.Location = new Point(274, 42);
            labelhome.Name = "labelhome";
            labelhome.Size = new Size(85, 25);
            labelhome.TabIndex = 0;
            labelhome.Text = "HOME";
            labelhome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(102, 252, 241);
            label2.Location = new Point(604, 9);
            label2.Name = "label2";
            label2.Size = new Size(20, 21);
            label2.TabIndex = 15;
            label2.Text = "X";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(826, 522);
            Controls.Add(panelhome);
            Controls.Add(panelbar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Form1_Load;
            panelbar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelhome.ResumeLayout(false);
            panelhome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelbar;
        private Panel panel2;
        private Panel panelhome;
        private Label labelhome;
        private Button buttonschedule;
        private Button buttonpersonaldetails;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
