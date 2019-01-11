using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtpTest2FlowLayout
{
    public partial class Form1 : Form
    {

        List<Echipament> Lista = new List<Echipament>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isCNP = false;
            string textB = textBox6.Text;

            string an = textB.Substring(1, 2);
            string luna = textB.Substring(3, 2);
            string zi = textB.Substring(5, 2);

            if ((textB[0] == '2') || (textB[0]== '1'))
            {
                an = 19 + an;
            }
            else
            {
                an = 20 + an;
            }
            string dateString = zi + "/" + luna + "/" + an;

            DateTime result;
            CultureInfo provider = CultureInfo.InvariantCulture;
            string format = "dd/MM/yyyy";
            try
            {
                result = DateTime.ParseExact(dateString, format, provider);
              //  Console.WriteLine("{0} converts to {1}.", dateString, result.ToString());
                if(textB.Length==13)
                {
                    isCNP = true;
                }
            }   
            catch (FormatException)
            {
              //  Console.WriteLine("{0} is not in the correct format.", dateString);
                isCNP = false;
            }
            if (!isCNP)
            {
                errorProvider1.SetError(textBox6, "CNP INVALID ?");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (isCNP) {

                Echipament echip = new Echipament(textBox1.Text,textBox2.Text,textBox3.Text,comboBox1.SelectedItem.ToString(),textBox5.Text,textBox6.Text);

                Button bt1 = new Button();
                bt1.Text = echip.Model;
                Lista.Add(echip);
                if (echip.Categorie == "Calculator")
                {
                    flowLayoutPanel1.Controls.Add(bt1);
                }
                else if (echip.Categorie == "Imprimanta")
                {
                    flowLayoutPanel2.Controls.Add(bt1);
                }
                else if (echip.Categorie == "Periferice")
                {
                    flowLayoutPanel3.Controls.Add(bt1);
                }
                else if (echip.Categorie == "Televizoare") {

                    flowLayoutPanel4.Controls.Add(bt1);

                } else if (echip.Categorie == "Mobilier") {

                    flowLayoutPanel5.Controls.Add(bt1);

                } else if (echip.Categorie == "Electronice") {

                    flowLayoutPanel6.Controls.Add(bt1);

                }
                bt1.Click += Bt1_Click;
    
            }
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            Button bt =(Button) sender;
            foreach (Echipament ech in Lista) {
                if (ech.Model == bt.Text) {
                    listBox1.Items.Add(ech.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Echipament echip in Lista) {
                string dir = Application.StartupPath;
                StreamWriter sw = new StreamWriter(dir + "\\agenda.txt", false);
                //...
                sw.WriteLine("***********new record ***************");
                sw.WriteLine(echip.ToString());
                
                //...
                sw.Close();
                Process.Start("notepad.exe", dir + "\\agenda.txt");

            }
        }
    }
}
