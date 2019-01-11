using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaDateMarinari
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);





        }
        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                progressBar1.Value++;
            }
            else
            {   


                timer1.Stop();

                string[] lines = System.IO.File.ReadAllLines(@"E:\Facultate\mtpTestPrep\BazaDateMarinari\BazaDateMarinari\TextFile1.txt");
                if (textBox1.Text == lines[0] && textBox2.Text == lines[1])
                {
                    MessageBox.Show("Login Successful!");
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
