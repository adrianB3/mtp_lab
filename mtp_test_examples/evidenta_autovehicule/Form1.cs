using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evidenta_autovehicule
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
            this.tableAdapterManager.UpdateAll(this.evidenta_autovehiculeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'evidenta_autovehiculeDataSet.Expeditii' table. You can move, or remove it, as needed.
            this.expeditiiTableAdapter.Fill(this.evidenta_autovehiculeDataSet.Expeditii);
            // TODO: This line of code loads data into the 'evidenta_autovehiculeDataSet.Autovehicule' table. You can move, or remove it, as needed.
            this.autovehiculeTableAdapter.Fill(this.evidenta_autovehiculeDataSet.Autovehicule);

        }
    }
}
