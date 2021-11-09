using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFiles
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int crSearch = 0;
        StringBuilder stringBuilder = new StringBuilder();
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            
                crSearch += 1;
            
            else
                crSearch -= 1;

        }



        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> result = new List<string>();
                for (int i = 0; i < textBoxDir.Lines.Count() - 1; i++)
                {
                    FindFiles findFiles = new FindFiles(textBoxSearch.Text, textBoxDir.Lines[i], crSearch);
                    result.AddRange(findFiles.Search());
                }
                foreach (var item in result)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch (ExtraSymbolsException ex)
            {
                MessageBox.Show(ex.Message);
                textBoxSearch.Text = string.Empty;
            }
            
       
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {

                stringBuilder.AppendLine(folderBrowserDialog.SelectedPath);
                textBoxDir.Text = stringBuilder.ToString();
            }
        }

        private void RadioButtonWordFull_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWordFull.Checked)

                crSearch += 10;

            else
                crSearch -= 10;
        }

        private void RadioButtonEndsWith_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEndsWith.Checked)

                crSearch += 100;

            else
                crSearch -= 100;
        }

        private void RadioButtonBeginsWith_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBeginsWith.Checked)

                crSearch += 1000;

            else
                crSearch -= 1000;
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && radioButtonShowFile.Checked)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = "/select, \"" + listBox1.SelectedItem.ToString() + "\"",
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
            else if (e.Button == MouseButtons.Left && radioButtonOpenFile.Checked)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = listBox1.SelectedItem.ToString(),
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }




                
            }
        private void SearchIsEnabled()
        {
            if (textBoxSearch.Text != null)
            {
                button1.Visible = true;
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }
    }
        
   
    }

