using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magazin_electrocasnice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void electrocasniceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.electrocasniceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.electroDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electroDataSet.Electrocasnice' table. You can move, or remove it, as needed.
            this.electrocasniceTableAdapter.Fill(this.electroDataSet.Electrocasnice);
            PopulateTree();
        }

        private void PopulateTree()
        {
            treeView.Nodes.Clear();
            treeView.Nodes.Add("Aparate frigorifice");
            treeView.Nodes.Add("Masini de spalat rufe");
            treeView.Nodes.Add("Masini de spalat vase");
            treeView.Nodes.Add("Aspiratoare");
            foreach (DataRowView drv in electrocasniceBindingSource.List)
            {
                if (drv["Categorie"].Equals("Aparat frigorific"))
                {
                    
                    TreeNode node = new TreeNode();
                    node.Text = drv["Producator"].ToString();
                    node.Name = drv["Id"].ToString();
                    treeView.Nodes[0].Nodes.Add(node);
                }
                if (drv["Categorie"].Equals("Masina de spalat rufe"))
                {
                    
                    TreeNode node = new TreeNode();
                    node.Text = drv["Producator"].ToString();
                    node.Name = drv["Id"].ToString();
                    treeView.Nodes[1].Nodes.Add(node);
                }
                if (drv["Categorie"].Equals("Masina de spalat vase"))
                {
                    
                    TreeNode node = new TreeNode();
                    node.Text = drv["Producator"].ToString();
                    node.Name = drv["Id"].ToString();
                    treeView.Nodes[2].Nodes.Add(node);
                }
                if (drv["Categorie"].Equals("Aspirator"))
                {
                    
                    TreeNode node = new TreeNode();
                    node.Text = drv["Producator"].ToString();
                    node.Name = drv["Id"].ToString();
                    treeView.Nodes[3].Nodes.Add(node);
                }
            }
        }

        private void InserareBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int i = random.Next();
            Validate();
            electrocasniceTableAdapter.Insert(i ,producatorTb.Text, Decimal.Parse(pretTb.Text), int.Parse(stocTb.Text), categorie.Text);
            this.electrocasniceBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(electroDataSet);
            electrocasniceTableAdapter.Fill(electroDataSet.Electrocasnice);
            PopulateTree();
        }

        private void stergereBtn_Click(object sender, EventArgs e)
        {
            Validate();
            foreach (DataRowView drv in electrocasniceBindingSource.List)
            {
                if (treeView.SelectedNode.Name.Equals(drv["Id"].ToString()))
                {
                    electrocasniceTableAdapter.Delete((int)drv["Id"], (string)drv["Producator"], (Decimal)drv["Pret"], (int)drv["Stoc"], (string)drv["Categorie"]);
                }
                this.electrocasniceBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(electroDataSet);
                electrocasniceTableAdapter.Fill(electroDataSet.Electrocasnice);
                break;
            }
            PopulateTree();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            detailsListBox.Items.Clear();
            foreach (DataRowView drv in electrocasniceBindingSource.List)
            {
                if (treeView.SelectedNode.Name.Equals(drv["Id"].ToString()))
                {
                    detailsListBox.Items.Add("Id: " + drv["Id"].ToString());
                    detailsListBox.Items.Add("Producator: " + (string)drv["Producator"]);
                    detailsListBox.Items.Add("Pret: " + drv["Pret"].ToString());
                    detailsListBox.Items.Add("Stoc: " + drv["Stoc"].ToString());
                    break;
                }
            }
        }
    }
}
