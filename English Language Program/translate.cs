using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace English_Language_Program
{
    public partial class translate : Form
    {
        List<string> AllWords = new List<string>();
        public translate()
        {
            InitializeComponent();
        }
        private void translate_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox2.SelectedIndex = comboBox3.SelectedIndex = 0;
                comboBox1.Items.AddRange(File.ReadAllLines(Path.Combine("Subjects", "Subjects.txt")));
                if (comboBox1.Items.Count != 0)
                    comboBox1.SelectedIndex = 0;
                container.Location = new Point((this.Width - container.Width) / 2, (this.Height - container.Height) / 2);
                this.BackColor
                               = container.BackColor =
                               comboBox1.BackColor =
                               textBox1.BackColor =
                               textBox2.BackColor =
                               comboBox3.BackColor =
                               comboBox2.BackColor
                               = Color.FromArgb(255, 44, 44, 44);
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Items.Count != 0)
                {
                    textBox2.Text = "";
                    AllWords.AddRange(File.ReadAllLines(Path.Combine(comboBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString() + ".txt")));
                    List<string> LT = new List<string>();
                    List<string> LI = new List<string>();
                    for (int i = 0; i < AllWords.Count; i++)
                    {
                        LT.Add(AllWords[i].Split(';')[1].ToString());
                        LI.Add(AllWords[i].Split(';')[0].ToString());
                    }
                    for (int i = 0; i < textBox1.Lines.Length; i++)
                    {
                        if (LT.Contains(textBox1.Lines[i]))
                        {
                            textBox2.Text += LI[LT.IndexOf(textBox1.Lines[i])].ToString() + TexTT.Text;
                        }
                        else
                            if (LI.Contains(textBox1.Lines[i]))
                        {
                            textBox2.Text += LT[LI.IndexOf(textBox1.Lines[i])].ToString() + TexTT.Text;
                        }
                        else
                            textBox2.Text += "Not Found '" + textBox1.Lines[i].ToString() + "' !" + TexTT.Text;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AllWords.Clear();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedIndex == 0)
                    textBox2.RightToLeft = RightToLeft.No;
                else if (comboBox3.SelectedIndex == 1)
                    textBox2.RightToLeft = RightToLeft.Yes;
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex == 0)
                    textBox1.RightToLeft = RightToLeft.No;
                else if (comboBox2.SelectedIndex == 1)
                    textBox1.RightToLeft = RightToLeft.Yes;
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        string[] Files = null;
        private void TextBox1_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                Files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (Path.GetExtension(Files[0]) == ".txt" && Files.Length == 1)
                    e.Effect = DragDropEffects.All;
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void TextBox1_DragDrop(object sender, DragEventArgs e)
        {
            textBox1.Text = File.ReadAllText(Files[0]);
        }
        private void Translate_Resize(object sender, EventArgs e)
        {
            container.Location = new Point((this.Width - container.Width) / 2, (this.Height - container.Height) / 2);
        }
    }
}