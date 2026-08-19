using System;
using System.Drawing;
using System.Windows.Forms;
namespace English_Language_Program
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }
        private void First_Load(object sender, EventArgs e)
        {
            this.BackColor=label4.BackColor = label5.BackColor = Color.FromArgb(255,44,44,44);
            panel1.Location = new Point((this.Width - panel1.Width )/2+160,(this.Height - panel1.Height)/2);
        }
    }
}