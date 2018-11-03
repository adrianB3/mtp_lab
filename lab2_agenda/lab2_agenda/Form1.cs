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

namespace lab2_agenda
{
    public partial class mainWindow : Form
    {
        private List<TreeNode> parentNodes = new List<TreeNode>();
        private List<Persoana> personasList = new List<Persoana>();
        private static int index = 0;
        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            parentNodes.Add(new TreeNode() { Text = "Prieteni", ImageIndex = 3 , Name = "-1"});
            parentNodes.Add(new TreeNode() { Text = "Colegi", ImageIndex = 2, Name = "-1" });
            parentNodes.Add(new TreeNode() { Text = "Rude", ImageIndex = 0, Name = "-1" });
            parentNodes.Add(new TreeNode() { Text = "Diversi", ImageIndex = 1, Name = "-1" });

            foreach (var node in parentNodes)
            {
                treeView.Nodes.Add(node);
            }
        }

        private void adaugaPersoana_Click(object sender, EventArgs e)
        {
            
            var pers = new Persoana(index++,numeTextBox.Text, dateTimePicker1.Value, telefonTextBox.Text, adresaTextBox.Text, (Categorie)categorieComboBox.SelectedIndex);

            personasList.Add(pers);
            TreeNode childNode = new TreeNode { Text = pers.Nume , Name = pers.Uid.ToString()};
            switch (pers.Categorie)
            {
                case Categorie.Prieteni: parentNodes[0].Nodes.Add(childNode); break;
                case Categorie.Colegi: parentNodes[1].Nodes.Add(childNode); break;
                case Categorie.Rude: parentNodes[2].Nodes.Add(childNode); break;
                case Categorie.Diversi: parentNodes[3].Nodes.Add(childNode); break;
            }
            propertyGrid.SelectedObject = pers;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach(var pers in personasList)
            {
                if(pers.Uid == int.Parse(e.Node.Name))
                {
                    propertyGrid.SelectedObject = pers;
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }

        private void cautareButton_Click(object sender, EventArgs e)
        {
            var pers = personasList.Find(x => x.Nume == cautareNume.Text);
            if(pers != null)
            {
                propertyGrid.SelectedObject = pers;
            }
        }

        private void stergeButton_Click(object sender, EventArgs e)
        {
            if(propertyGrid.SelectedObject != null)
            {
                foreach (var pers in personasList)
                {
                    if (pers == propertyGrid.SelectedObject)
                    {                     
                        personasList.Remove(pers);
                        propertyGrid.SelectedObject = null;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("nothing to delete");
                    }
                }

                foreach (var node in parentNodes)
                {
                    treeView.Nodes.Remove(node);
                }
                parentNodes.Clear();
                parentNodes.Add(new TreeNode() { Text = "Prieteni", ImageIndex = 3, Name = "-1" });
                parentNodes.Add(new TreeNode() { Text = "Colegi", ImageIndex = 2, Name = "-1" });
                parentNodes.Add(new TreeNode() { Text = "Rude", ImageIndex = 0, Name = "-1" });
                parentNodes.Add(new TreeNode() { Text = "Diversi", ImageIndex = 1, Name = "-1" });
               

                foreach (var node in parentNodes)
                {
                    treeView.Nodes.Add(node);
                }

                foreach(var pers in personasList)
                {
                    TreeNode childNode = new TreeNode { Text = pers.Nume, Name = pers.Uid.ToString() };
                    switch (pers.Categorie)
                    {
                        case Categorie.Prieteni: parentNodes[0].Nodes.Add(childNode); break;
                        case Categorie.Colegi: parentNodes[1].Nodes.Add(childNode); break;
                        case Categorie.Rude: parentNodes[2].Nodes.Add(childNode); break;
                        case Categorie.Diversi: parentNodes[3].Nodes.Add(childNode); break;
                    }
                }
            }

            
        }

        private void salveazaFisier_Click(object sender, EventArgs e)
        {
            string dir = Application.StartupPath;
            StreamWriter sw = new StreamWriter(dir + "\\agenda.txt", false);
           
            foreach(var pers in personasList)
            {
                sw.WriteLine("Nume: " + pers.Nume);
                sw.WriteLine("Data Nasterii: " + pers.DataNasterii.ToLongDateString());
                sw.WriteLine("Nr Telefon: " + pers.NumarTelefon);
                sw.WriteLine("Adresa: " + pers.Adresa);
                sw.WriteLine("Categorie: " + pers.Categorie.ToString());

            }
           
            sw.Close();
            Process.Start("notepad.exe", dir + "\\agenda.txt"); 
        }
    }
}
