using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplaceText
{
    public partial class Form1 : Form
    {
        private string loadedText="";
        private string destPath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoadTextTag_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                //To remove empty line
                string text = File.ReadAllText(filePath);
                text = Regex.Replace(text, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
                File.WriteAllText(filePath, text);

                string[] tagValue = File.ReadAllLines(filePath);
                foreach (string tagV in tagValue)
                {
                    lstBxTagValuePair.Items.Add(tagV);
                }
            }
        }

        private void BtnLoadSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,
              
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadedText = File.ReadAllText(openFileDialog1.FileName);
                
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (loadedText != "" && destPath!="")
            {
                var lstTagValue = lstBxTagValuePair.Items;
                string tempLoadedText;
                
                //for each line means a file
                foreach(string tgV in lstTagValue)
                {
                    tempLoadedText = loadedText;
                    string[] valuePair = tgV.Split(';'); //getting seperated valuePair
                    string reportName = "";
                    foreach(string vP in valuePair)
                    {
                        string tag = (vP.Trim()).Split('>')[0] + '>';
                        string value = (vP.Trim()).Split('>')[1];

                        //Now replace the tag with value and write it with a filename
                        tempLoadedText = tempLoadedText.Replace(tag, value);

                    }
                    reportName = valuePair[5].Split('>')[1];
                    if(File.Exists(destPath + "\\" + reportName + ".xml"))
                    {
                        MessageBox.Show("File is already there");
                        return;
                    }
                    File.WriteAllText(destPath +"\\"+ reportName+ ".txt",tempLoadedText);
                    
                }

                MessageBox.Show(@"All file written in "+ destPath);
            }
            else
            {
                MessageBox.Show("Load Source file and destination path first");
            }
        }

        private void BtnBrowseDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog()== DialogResult.OK)
            {
                destPath = folderBrowser.SelectedPath;
            }
        }
    }
}
