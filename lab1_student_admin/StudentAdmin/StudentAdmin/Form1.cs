using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdmin
{
    public partial class main : Form
    {
        private List<Student> listaStudenti = new List<Student>();
        public main()
        {
            InitializeComponent();
        }

        private void adaugareStudent(object sender, EventArgs e)
        {
            try
            {
                listaStudenti.Add(new Student(
                    numeTextBox.Text,
                    Byte.Parse(numericUpDown1.Value.ToString()),
                    Byte.Parse(comboBox1.Text),
                    new byte[] {
                        Byte.Parse(comboBox2.Text),
                        Byte.Parse(comboBox3.Text),
                        Byte.Parse(comboBox4.Text),
                        Byte.Parse(comboBox5.Text),
                        Byte.Parse(comboBox6.Text),
                        }
                    ));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
                
            afisareStudentiListBox.Items.Clear();
            foreach (var stud in listaStudenti)
            {
                afisareStudentiListBox.Items.Add(stud.ToString());
            }
        }

        private void ordonareN_Click(object sender, EventArgs e)
        {
            var comparer = new Student.SortByNameAsc();
            listaStudenti.Sort(comparer);
            afisareStudentiListBox.Items.Clear();
            foreach (var stud in listaStudenti)
            {
                afisareStudentiListBox.Items.Add(stud.ToString());
            }
        }

        private void ordonareM_Click(object sender, EventArgs e)
        {
            var comparer = new Student.SortByAverageAsc();
            listaStudenti.Sort(comparer);
            afisareStudentiListBox.Items.Clear();
            foreach (var stud in listaStudenti)
            {
                afisareStudentiListBox.Items.Add(stud.ToString());
            }
        }

        private void afisareStudAnul_Click(object sender, EventArgs e)
        {
            afisareStudentiListBox.Items.Clear();
            foreach (var stud in listaStudenti)
            {
                if(stud.AnStudiu == Byte.Parse(comboBox7.Text))
                    afisareStudentiListBox.Items.Add(stud.ToString());
            }
        }

        private void cautareNume_Click(object sender, EventArgs e)
        {
            afisareStudentiListBox.Items.Clear();
            foreach (var stud in listaStudenti)
            {
                if (stud.NumeStudent.Equals(cautareNumeTextBox.Text))
                    afisareStudentiListBox.Items.Add(stud.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sel = afisareStudentiListBox.SelectedItem;
            foreach (var stud in listaStudenti)
            {
                if(sel.Equals(stud.ToString()))
                {
                    listaStudenti.Remove(stud);
                    break;
                }
            }

            afisareStudentiListBox.Items.Clear();
            foreach (var stud in listaStudenti)
            {
                afisareStudentiListBox.Items.Add(stud.ToString());
            }
        }
    }
}
