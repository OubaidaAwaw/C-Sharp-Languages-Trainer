using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace English_Language_Program
{
    public partial class input : Form
    {
        int number;
        public input(int number = 0)
        {
            this.number = number;
            InitializeComponent();
        }
        private void input_Load(object sender, EventArgs e)
        {
            try
            { 
            container.Location = new Point((this.Width - container.Width) / 2, (this.Height - container.Height) / 2);
            comboBox1.Items.AddRange(File.ReadAllLines(Path.Combine("Subjects", "Subjects.txt")));
            if (comboBox1.Items.Count != 0)
                comboBox1.SelectedIndex = number;
            this.BackColor
                = container.BackColor =
                comboBox1.BackColor =
                textBox1.BackColor =
                textBox2.BackColor =
                comboBox3.BackColor =
                comboBox2.BackColor
                = Color.FromArgb(255, 44, 44, 44);
                comboBox2.SelectedIndex = 1;
                comboBox3.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void input_Resize(object sender, EventArgs e)
        {
            container.Location = new Point((this.Width - container.Width) / 2, (this.Height - container.Height) / 2);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
            if (comboBox2.SelectedIndex == 1)
                textBox1.RightToLeft = RightToLeft.No;
            else if (comboBox2.SelectedIndex == 0)
                textBox1.RightToLeft = RightToLeft.Yes;
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
            if (comboBox3.SelectedIndex == 1)
                textBox2.RightToLeft = RightToLeft.No;
            else if (comboBox3.SelectedIndex == 0)
                textBox2.RightToLeft = RightToLeft.Yes;
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if(!textBox2.Text.Equals(""))
            {
                if(((int)(textBox2.Text[0])) < 200)
                {
                    textBox2.RightToLeft = RightToLeft.No;
                    comboBox3.SelectedIndex = 1;
                }
                else
                {
                    textBox2.RightToLeft = RightToLeft.Yes;
                    comboBox3.SelectedIndex = 0;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    if (textBox1.Text == "" && textBox2.Text == "")
                    {
                        MessageBox.Show("Please Fill The Empty Failds!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        if (textBox1.Lines.Length == textBox2.Lines.Length)
                        {
                            for (int i = 0; i < textBox1.Lines.Length; i++)
                            {
                                using (StreamWriter strw = new StreamWriter(Path.Combine(comboBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString() + ".txt"), true))
                                {
                                    strw.WriteLine(textBox1.Lines[i] + ";" + textBox2.Lines[i]);
                                }
                            }
                            textBox1.Text = textBox2.Text = "";
                            comboBox2.SelectedIndex = comboBox3.SelectedIndex = 0;
                        }
                        else
                        {
                            if (textBox1.Lines.Length > textBox2.Lines.Length)
                                MessageBox.Show("Words > Translate !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            else
                                MessageBox.Show("Words < Translate !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select A Subject!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == -1)
            {
                MessageBox.Show("Please Create A Subject First Please", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void TextBox2_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                textBox2.Text = e.Data.GetData(DataFormats.Text, true).ToString();
            }
        }

        private void TextBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

    }
}