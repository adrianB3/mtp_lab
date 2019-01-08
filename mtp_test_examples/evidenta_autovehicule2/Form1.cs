using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evidenta_autovehicule2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void autovehiculeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autovehiculeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autovehiculeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autovehiculeDataSet.Expeditii' table. You can move, or remove it, as needed.
            this.expeditiiTableAdapter.Fill(this.autovehiculeDataSet.Expeditii);
            // TODO: This line of code loads data into the 'autovehiculeDataSet.Autovehicule' table. You can move, or remove it, as needed.
            this.autovehiculeTableAdapter.Fill(this.autovehiculeDataSet.Autovehicule);
            expeditiiDataGridView.Columns.Add("L/100Km", "L/100Km");
            int count = 0;
            foreach (DataRowView item in expeditiiBindingSource.List)
            {             
                expeditiiDataGridView[5, count].Value = (float.Parse(item["Combustibil"].ToString()) * 100) / float.Parse(item["Distanta"].ToString());
                count++;
            }
        }

        private void autovehiculeDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            float kmParcursi = 0f;
            int count = 0;
            
            foreach (DataRowView item in expeditiiBindingSource.List)
            {
                kmParcursi += float.Parse(item["Distanta"].ToString());

            }
           
            totalkmlabel.Text = kmParcursi.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataRowView item in expeditiiBindingSource.List)
            {
                expeditiiDataGridView[5, count].Value = (float.Parse(item["Combustibil"].ToString()) * 100) / float.Parse(item["Distanta"].ToString());
                count++;
            }
        }
    }
}
