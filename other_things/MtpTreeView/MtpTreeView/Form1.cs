using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtpTest1
{
    public partial class Form1 : Form
    {

        List<Produs> Lista = new List<Produs>();
        int childCount=0;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            childCount++;
            Categorie f = (Categorie)(comboBox1.SelectedIndex);
            Produs p = new Produs(textBox1.Text,textBox2.Text,dateTimePicker1.Value,Int32.Parse(textBox3.Text),Int32.Parse(textBox4.Text),f);

            Lista.Add(p);
            TreeNode childNode = new TreeNode();
            childNode.Text = p.Denumire;
            childNode.Name = "child_1" + childCount;

            for (int i=0;i<3;i++) {

                if (treeView1.Nodes[i].Text == p.Categorie.ToString()) {

                    treeView1.Nodes[i].Nodes.Add(childNode);
                    propertyGrid1.SelectedObject = p;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dir = Application.StartupPath;
            StreamWriter sw = new StreamWriter(dir + "\\Stoc.txt", false);
            //...

            foreach(Produs pr in Lista){
                sw.WriteLine("**************************************************");
                sw.WriteLine("Denumire: " + pr.Denumire);
                sw.WriteLine("Producator: " + pr.Producator);
                sw.WriteLine("Data expirare: " + pr.DataExpirare);
                sw.WriteLine("Pret: " + pr.Pret);
                sw.WriteLine("Stoc: " + pr.Stoc);
                sw.WriteLine("Categorie : " + pr.Categorie);
            }

            //...
            sw.Close();
            Process.Start("notepad.exe", dir + "\\Stoc.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            foreach (Produs pr in Lista)
            {
                if (pr.Denumire == treeView1.SelectedNode.Text) {
                    pr.Stoc = pr.Stoc - Int32.Parse(textBox5.Text); // update stoc 
                }
            }

           // treeView1.SelectedNode.Remove(); daca vrei sa stergi nodu din treeview
        }
    }
}
