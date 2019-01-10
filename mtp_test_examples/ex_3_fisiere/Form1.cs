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

namespace ex_3_fisiere
{
    public partial class Form1 : Form
    {
        private List<Button> listOfAddedButtons = new List<Button>();
        Label label = new Label();
        TextBox tb1 = new TextBox() { Multiline = true, Text = "Continut fisier", Width = 170, Height = 200 };
        TextBox tb2 = new TextBox() { Multiline = true, Text = "Categorie fisier", Width = 170, Height = 200 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (var item in Directory.EnumerateFiles(pathTb.Text))
            {
                var btn = new Button() { Text = Path.GetFileNameWithoutExtension(item), Width=150 };
                listOfAddedButtons.Add(btn);
               
            }
            foreach (var item in listOfAddedButtons)
            {
                item.Click += Btn_Click;
                buttonFlowLayoutPanel.Controls.Add(item);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            textBoxLayoutPanel.Controls.Clear();
            Button btn = sender as Button;
            
            label.Text = btn.Text;
            textBoxLayoutPanel.Controls.Add(label);
            string[] lines = File.ReadAllLines("Butoane.txt");
            foreach (var item in lines)
            {
                string[] things = item.Split(';');
                if (things[0].Equals(btn.Text))
                {
                    tb1.Text = things[1];
                    tb2.Text = things[2];
                }             
            }

            textBoxLayoutPanel.Controls.Add(tb1);
            textBoxLayoutPanel.Controls.Add(tb2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Butoane.txt");
            bool update = false;
            foreach (var item in lines)
            {
                string[] things = item.Split(';');
                if (things[0].Equals(label.Text))
                {
                    using (StreamWriter writer = new StreamWriter("Butoane.txt",true))
                    {
                        writer.WriteLine(label.Text + ";" + tb1.Text + ";" + tb2.Text);
                    }
                    update = true;
                    break;
                }
            }

            if(update == false)
            {
                using (StreamWriter writer = new StreamWriter("Butoane.txt",true))
                {
                    
                    writer.WriteLine(label.Text + ";" + tb1.Text + ";" + tb2.Text);
                }
            }
            
        }
    }
}
