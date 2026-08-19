using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
namespace English_Language_Program
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            try
            { 
            btnhome.BackColor = Color.FromArgb(150,33,33,33);
            this.Size = new Size(1200, 726);
                ShowHome();
                CheckSubjectFolder();
                flpcontainer.BackColor=label1.ForeColor = Color.FromArgb(255, 44, 44, 44);
                flpcontainer.ForeColor =
                panel1.BackColor =
                btnenter.ForeColor =
                btnexport.ForeColor =
                btnemport.ForeColor =
                btntest.ForeColor =
                btntrans.ForeColor =
                btnwords.ForeColor =
                btncreate.ForeColor =
                btnhome.ForeColor =
                Color.FromArgb(255,255, 128, 0);
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void btncreate_Click_1(object sender, EventArgs e)
        {
            btncreate.BackColor = Color.FromArgb(225, 33, 33, 33);
            btnexport.BackColor =
            btnemport.BackColor =
              btnwords.BackColor =
             btntest.BackColor =
             btnhome.BackColor =
            btntrans.BackColor =
              btnenter.BackColor = Color.FromArgb(255, 44, 44, 44);
            ShowCreate();
        }
        private void btnenter_Click_1(object sender, EventArgs e)
        {
            if (CheckSubjectFile())
            {
                btnenter.BackColor = Color.FromArgb(225, 33,33,33);
                btnexport.BackColor =
                btnemport.BackColor =
                  btntest.BackColor =
                 btntrans.BackColor =
                 btnwords.BackColor =
                btncreate.BackColor =
                  btnhome.BackColor =Color.FromArgb(255,44,44,44);
                input Ent = new input();
                Controls[2].Controls.Clear();
                Ent.MdiParent = this;
                Ent.Dock = DockStyle.Fill;
                Ent.Show();
            }
        }
        private void btnwords_Click_1(object sender, EventArgs e)
        {
            if (CheckSubjectFile())
            {
                btnwords.BackColor = Color.FromArgb(225, 33, 33, 33);
                btnexport.BackColor =
                btnemport.BackColor =
                  btntest.BackColor =
                 btntrans.BackColor =
                 btnhome.BackColor =
                btncreate.BackColor =
                  btnenter.BackColor = Color.FromArgb(255, 44, 44, 44);
                Words Ent = new Words();
                Controls[2].Controls.Clear();
                Ent.MdiParent = this;
                Ent.Dock = DockStyle.Fill;
                Ent.Show();
            }
        }
        private void btntest_Click_1(object sender, EventArgs e)
        {
            if (CheckSubjectFile())
            {
                btntest.BackColor = Color.FromArgb(225, 33, 33, 33);
                btnexport.BackColor =
                btnemport.BackColor =
                  btnwords.BackColor =
                 btntrans.BackColor =
                 btnhome.BackColor =
                btncreate.BackColor =
                  btnenter.BackColor = Color.FromArgb(255, 44, 44, 44);
                Test Ent = new Test();
                Controls[2].Controls.Clear();
                Ent.MdiParent = this;
                Ent.Dock = DockStyle.Fill;
                Ent.Show();
            }
        }
        private void btntrans_Click_1(object sender, EventArgs e)
        {
            if (CheckSubjectFile())
            {
                btntrans.BackColor = Color.FromArgb(225, 33, 33, 33);
                btnexport.BackColor =
                btnemport.BackColor =
                  btnwords.BackColor =
                 btntest.BackColor =
                 btnhome.BackColor =
                btncreate.BackColor =
                  btnenter.BackColor = Color.FromArgb(255, 44, 44, 44);
                translate Ent = new translate();
                Controls[2].Controls.Clear();
                Ent.MdiParent = this;
                Ent.Dock = DockStyle.Fill;
                Ent.Show();
            }
        }
        private void btnemport_Click(object sender, EventArgs e)
        {
            if (CheckSubjectFile())
            {
                btnemport.BackColor = Color.FromArgb(225, 33, 33, 33);
                btnexport.BackColor =
                btnenter.BackColor =
                  btntest.BackColor =
                 btntrans.BackColor =
                 btnwords.BackColor =
                btncreate.BackColor =
                  btnhome.BackColor = Color.FromArgb(255, 44, 44, 44);
                Import Ent = new Import();
                Controls[2].Controls.Clear();
                Ent.MdiParent = this;
                Ent.Dock = DockStyle.Fill;
                Ent.Show();
            }
        }
        private void btnexport_Click_1(object sender, EventArgs e)
        {
            if (CheckSubjectFile())
            {
                btnexport.BackColor = Color.FromArgb(225, 33, 33, 33);
                btnemport.BackColor =
                btnenter.BackColor =
                  btntest.BackColor =
                 btntrans.BackColor =
                 btnwords.BackColor =
                btncreate.BackColor =
                  btnhome.BackColor = Color.FromArgb(255, 44, 44, 44);
                Export Ent = new Export();
                Controls[2].Controls.Clear();
                Ent.MdiParent = this;
                Ent.Dock = DockStyle.Fill;
                Ent.Show();
            }
        }
        private void btnhome_Click_1(object sender, EventArgs e)
        {
            btnhome.BackColor = Color.FromArgb(225, 33, 33, 33);
            btnexport.BackColor =
            btnemport.BackColor =
              btntest.BackColor =
             btntrans.BackColor =
             btnwords.BackColor =
            btncreate.BackColor =
              btnenter.BackColor = Color.FromArgb(255, 44, 44, 44);
            ShowHome();
        }
        public bool CheckSubjectFile()
        {
            bool IO = true;
            try
            { 
            CheckSubjectFolder();
            StreamReader strr = new StreamReader(Path.Combine("Subjects", "Subjects.txt"));
            string TextAll = strr.ReadToEnd();
            strr.Close();
            if (TextAll == null || TextAll == "")
            {
                if (MessageBox.Show("Please Create A Subject First!!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    ShowCreate();
                    IO = false;
                }
            }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            return IO;
        }
        private void CheckSubjectFolder()
        {
            try
            { 
            if (!Directory.Exists("Subjects") || !File.Exists(Path.Combine("Subjects", "Subjects.txt")))
            {
                Directory.CreateDirectory("Deleted");
                Directory.CreateDirectory("Subjects");
                StreamWriter strw = new StreamWriter(Path.Combine("Subjects", "Subjects.txt"), true);
                strw.Close();
            }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void ShowHome()
        {
            if (CheckSubjectFile())
            {
                Controls[2].Controls.Clear();
                First Ent = new First();
                Ent.MdiParent = this;
                Ent.Dock = DockStyle.Fill;
                Ent.Show();
            }
        }
        private void ShowCreate()
        {
            if (CheckSubjectFile())
            {
                Controls[2].Controls.Clear();
                Create Ent = new Create();
                Ent.MdiParent = this;
                Ent.Dock = DockStyle.Fill;
                Ent.Show();
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Red;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            { 
            if (this.Width< Screen.PrimaryScreen.Bounds.Width && this.Height < Screen.PrimaryScreen.Bounds.Height)
            {
                pictureBox2.Image = Properties.Resources.maximaze;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.minimized;
                this.WindowState = FormWindowState.Normal;
            }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int MD, MU, MM;
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MD = 1;
            MU = e.X;
            MM = e.Y;
        }
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MD == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MU, MousePosition.Y - MM);
            }
        }
        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MD = 0;
        }
    }
}