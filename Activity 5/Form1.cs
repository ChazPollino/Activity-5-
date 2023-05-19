using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Activity_5
{
    public partial class ConvertTheWords : Form
    {
        public ConvertTheWords()
        {
            InitializeComponent();
        }

        private void NamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowNamesButton_Click(object sender, EventArgs e)
        {
            NamesListBox.Items.Add("Christmas");
            NamesListBox.Items.Add("American");
            NamesListBox.Items.Add("Atlas");
            NamesListBox.Items.Add("Adaline");
            NamesListBox.Items.Add("Charlie");
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            Stream mystream;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (OpenWordFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OpenWordFile.InitialDirectory = "C:\\Users\\Dusty4G\\source\\repos\\Activity 5\\Activity 5\\bin\\Debug";
                if ((mystream = OpenWordFile.OpenFile()) != null)
                {
                    string strfilename = OpenWordFile.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    ConvertNamesTextBox.Text = filetext;
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ConvertNamesTextBox.Text = "";
            NamesListBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
