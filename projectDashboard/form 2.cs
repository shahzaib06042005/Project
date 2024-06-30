using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDashboard
{
    public partial class form_2 : Form
    {
        public form_2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            labelfirstname = new Label();
            labellastname = new Label();
            gender = new Label();
            labeldepart = new Label();
            labelmail = new Label();
            labelcontact = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            radioButtonmale = new RadioButton();
            radioButtonfemale = new RadioButton();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(102, 252, 241);
            label1.Location = new Point(223, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 34);
            label1.TabIndex = 0;
            label1.Text = "Personal Details";
            label1.Click += label1_Click;
            // 
            // labelfirstname
            // 
            labelfirstname.AutoSize = true;
            labelfirstname.Font = new Font("Copperplate Gothic Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelfirstname.ForeColor = Color.FromArgb(69, 162, 158);
            labelfirstname.Location = new Point(57, 98);
            labelfirstname.Name = "labelfirstname";
            labelfirstname.Size = new Size(92, 16);
            labelfirstname.TabIndex = 1;
            labelfirstname.Text = "first name";
            // 
            // labellastname
            // 
            labellastname.AutoSize = true;
            labellastname.Font = new Font("Copperplate Gothic Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labellastname.ForeColor = Color.FromArgb(69, 162, 158);
            labellastname.Location = new Point(57, 162);
            labellastname.Name = "labellastname";
            labellastname.Size = new Size(86, 16);
            labellastname.TabIndex = 2;
            labellastname.Text = "last name";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Copperplate Gothic Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gender.ForeColor = Color.FromArgb(69, 162, 158);
            gender.Location = new Point(57, 233);
            gender.Name = "gender";
            gender.Size = new Size(67, 16);
            gender.TabIndex = 3;
            gender.Text = "gender";
            // 
            // labeldepart
            // 
            labeldepart.AutoSize = true;
            labeldepart.Font = new Font("Copperplate Gothic Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeldepart.ForeColor = Color.FromArgb(69, 162, 158);
            labeldepart.Location = new Point(46, 297);
            labeldepart.Name = "labeldepart";
            labeldepart.Size = new Size(104, 16);
            labeldepart.TabIndex = 4;
            labeldepart.Text = "Department";
            // 
            // labelmail
            // 
            labelmail.AutoSize = true;
            labelmail.Font = new Font("Copperplate Gothic Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelmail.ForeColor = Color.FromArgb(69, 162, 158);
            labelmail.Location = new Point(46, 361);
            labelmail.Name = "labelmail";
            labelmail.Size = new Size(52, 16);
            labelmail.TabIndex = 5;
            labelmail.Text = "e-mail";
            // 
            // labelcontact
            // 
            labelcontact.AutoSize = true;
            labelcontact.Font = new Font("Copperplate Gothic Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcontact.ForeColor = Color.FromArgb(69, 162, 158);
            labelcontact.Location = new Point(46, 432);
            labelcontact.Name = "labelcontact";
            labelcontact.Size = new Size(91, 16);
            labelcontact.TabIndex = 6;
            labelcontact.Text = "contact #";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(195, 290);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(195, 359);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(195, 425);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 11;
            // 
            // radioButtonmale
            // 
            radioButtonmale.AutoSize = true;
            radioButtonmale.Font = new Font("Copperplate Gothic Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonmale.ForeColor = Color.FromArgb(69, 162, 158);
            radioButtonmale.Location = new Point(195, 237);
            radioButtonmale.Name = "radioButtonmale";
            radioButtonmale.Size = new Size(63, 20);
            radioButtonmale.TabIndex = 12;
            radioButtonmale.TabStop = true;
            radioButtonmale.Text = "male";
            radioButtonmale.UseVisualStyleBackColor = true;
            // 
            // radioButtonfemale
            // 
            radioButtonfemale.AutoSize = true;
            radioButtonfemale.Font = new Font("Copperplate Gothic Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonfemale.ForeColor = Color.FromArgb(69, 162, 158);
            radioButtonfemale.Location = new Point(264, 237);
            radioButtonfemale.Name = "radioButtonfemale";
            radioButtonfemale.Size = new Size(81, 20);
            radioButtonfemale.TabIndex = 13;
            radioButtonfemale.TabStop = true;
            radioButtonfemale.Text = "female";
            radioButtonfemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(102, 252, 241);
            label2.Location = new Point(720, 9);
            label2.Name = "label2";
            label2.Size = new Size(20, 21);
            label2.TabIndex = 14;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled_design;
            pictureBox1.Location = new Point(2, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // form_2
            // 
            BackColor = Color.FromArgb(11, 12, 16);
            ClientSize = new Size(752, 496);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(radioButtonfemale);
            Controls.Add(radioButtonmale);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelcontact);
            Controls.Add(labelmail);
            Controls.Add(labeldepart);
            Controls.Add(gender);
            Controls.Add(labellastname);
            Controls.Add(labelfirstname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_2";
            StartPosition = FormStartPosition.CenterScreen;
            Load += form_2_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Label label1;
        private Label labelfirstname;
        private Label labellastname;
        private Label gender;
        private Label labeldepart;
        private Label labelmail;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private RadioButton radioButtonmale;
        private RadioButton radioButtonfemale;
        private Label label2;
        private PictureBox pictureBox1;
        private Label labelcontact;

        private void form_2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }

}

