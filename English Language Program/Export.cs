using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Xceed.Document.NET;
using Xceed.Words.NET;
using System.Collections.Generic;
using System.Diagnostics;
namespace English_Language_Program
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }
        private void Export_Load(object sender, EventArgs e)
        {
            try
            {
                button3.PerformClick();
                this.BackColor = 
                groupBox1.BackColor = 
                listBox1.BackColor =
                txtsubjectname.BackColor =
                Color.FromArgb(255, 44, 44, 44);
                groupBox1.Location = new Point((this.Width - groupBox1.Width) / 2, (this.Height - groupBox1.Height) / 2);
                listBox1.Items.AddRange(File.ReadAllLines(Path.Combine("Subjects", "Subjects.txt")));
                button3.PerformClick();
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void Export_Resize(object sender, EventArgs e)
        {
            groupBox1.Location = new Point((this.Width - groupBox1.Width) / 2, (this.Height - groupBox1.Height) / 2);
        }
        string Hadaf= null , From = null;
        private void Button3_Click(object sender, EventArgs e)
        {
            Hadaf = From = null;
            txtsubjectname.Clear();
            if(listBox1.Items.Count != 0 )
            listBox1.SelectedIndex = 0;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsubjectname.Text != "" && txtsubjectname.Text != null)
                {
                    if (Hadaf == null && From == null)
                    {
                        button3.PerformClick();
                    }
                    else
                    {
                        string directoryPath = txtsubjectname.Text;
                        string filePath = Path.Combine(directoryPath, listBox1.SelectedItem.ToString() + ".docx");
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }
                        CreateDocumentWithTable(filePath);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select A Subject From The List And Browse!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            { 
            if(listBox1.SelectedIndex != -1)
            {
                if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                     Hadaf = txtsubjectname.Text = folderBrowserDialog1.SelectedPath.ToString();
                     From = listBox1.SelectedItem.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please Select A Subject From The List!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void CreateDocumentWithTable(string filePath)
        {
            if (!File.Exists(filePath))
            {
                List<string> DataFilxe = new List<string>();
                DataFilxe.AddRange(File.ReadLines(Path.Combine(listBox1.SelectedItem.ToString(), listBox1.SelectedItem.ToString() + ".txt")));
                using (StreamReader STR = new StreamReader(Path.Combine(listBox1.SelectedItem.ToString(), listBox1.SelectedItem.ToString() + ".txt")))
                {
                    for (; ; )
                    {
                        string ob = STR.ReadLine();
                        if (ob != null)
                        {
                            DataFilxe.Add(ob);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                using (DocX document = DocX.Create(filePath))
                {
                    document.InsertParagraph("Words").FontSize(20).Bold().Alignment = Alignment.center;
                    Table table = document.AddTable(DataFilxe.Count / 3, 3);
                    for (int i = 0, k = 0; i < DataFilxe.Count - 2 ; i += 3, k++)
                    {
                        table.Rows[k].Cells[0].Paragraphs[0].Append(DataFilxe[i].Replace(';', ' ')).FontSize(12).Bold().Alignment = Alignment.center;
                        table.Rows[k].Cells[1].Paragraphs[0].Append(DataFilxe[i + 1].Replace(';', ' ')).FontSize(12).Bold().Alignment = Alignment.center;
                        table.Rows[k].Cells[2].Paragraphs[0].Append(DataFilxe[i + 2].Replace(';', ' ')).FontSize(12).Bold().Alignment = Alignment.center;
                    }
                    document.InsertTable(table);
                    document.Save();
                }
                Process.Start(filePath);
            }
            else
            {
                MessageBox.Show($"Document can't save you have the same file in the same folder: {filePath}");
            }
        }
    }
}