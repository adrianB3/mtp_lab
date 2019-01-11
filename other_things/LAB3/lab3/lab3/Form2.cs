using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp
{
    public partial class Form2 : Form
    {
        private string cnp;
        private DateTime data;
        private string caleImagine;
        private string diagnostic;
        private string comentarii;

        public Form2(string CNP)
        {
            InitializeComponent();
            cnpTextBox.Text = CNP;
        }

        public string Cnp
        {
            get { return cnp; }
        }
        public DateTime Data
        {
            get { return data; }
        }
        public string CaleImagine
        {
            get { return caleImagine; }
        }
        public string Diagnostic
        {
            get { return diagnostic; }
        }
        public string Comentarii
        {
            get { return comentarii; }
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageTextBox.Text = openFileDialog.FileName;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            cnp = cnpTextBox.Text;
            data = dateTimePicker.Value;
            caleImagine = imageTextBox.Text;
            diagnostic = diagnosticTextBox.Text;
            comentarii = comentariiTextBox.Text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
