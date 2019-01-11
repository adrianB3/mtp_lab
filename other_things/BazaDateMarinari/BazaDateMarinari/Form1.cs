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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void marinarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marinarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marinariDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marinariDataSet.Vas' table. You can move, or remove it, as needed.
            this.vasTableAdapter.Fill(this.marinariDataSet.Vas);
            // TODO: This line of code loads data into the 'marinariDataSet.Marinar' table. You can move, or remove it, as needed.
            this.marinarTableAdapter.Fill(this.marinariDataSet.Marinar);

            Login log = new Login();
            if (log.ShowDialog() == DialogResult.Cancel)
                this.Close();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            marinarTableAdapter.Insert(Int32.Parse(textBox1.Text),Int32.Parse(textBox2.Text),textBox3.Text);
            tableAdapterManager.UpdateAll(marinariDataSet);
            marinarTableAdapter.Fill(marinariDataSet.Marinar);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            vasTableAdapter.Insert(Int32.Parse(textBox4.Text), textBox5.Text, textBox6.Text);
            tableAdapterManager.UpdateAll(marinariDataSet);
            vasTableAdapter.Fill(marinariDataSet.Vas);
        }
    }
}
