using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Mp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDateMihaiDataSet.Radiografii' table. You can move, or remove it, as needed.
            this.radiografiiTableAdapter.Fill(this.bazaDateMihaiDataSet.Radiografii);
            // TODO: This line of code loads data into the 'bazaDateMihaiDataSet.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.bazaDateMihaiDataSet.Pacienti);
        }

        private void salveazaButton_Click(object sender, EventArgs e)
        {
            Validate();
            pacientiBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(bazaDateMihaiDataSet);
        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            string cnp = ((DataRowView)pacientiBindingSource.Current)["CNP"].ToString();
            Form2 adaugaRadiografie = new Form2(cnp);
            if (adaugaRadiografie.ShowDialog() == DialogResult.OK)
            {
                // Adaugarea datelor
                radiografiiTableAdapter.Insert(adaugaRadiografie.Cnp, adaugaRadiografie.CaleImagine, adaugaRadiografie.Data, adaugaRadiografie.Diagnostic, adaugaRadiografie.Comentarii);
                // Salvarea datelor
                tableAdapterManager.UpdateAll(bazaDateMihaiDataSet);
                // Reincarcarea datelor
                radiografiiTableAdapter.Fill(bazaDateMihaiDataSet.Radiografii);
            }
        }

        private void pacientiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            PictureBox pictureBox;
            foreach (DataRowView drv in radiografiiBindingSource.List)
            {
                string cnp = ((DataRowView)pacientiBindingSource.Current)["CNP"].ToString();
                string imgCnp = ((DataRowView)radiografiiBindingSource.Current)["CNP"].ToString();
                if (cnp.Equals(imgCnp))
                {
                    pictureBox = new PictureBox();
                    pictureBox.Name = "pictureBox1";
                    pictureBox.SetBounds(0, 0, 150, 150);
                    pictureBox.BackColor = Color.Black;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Image = Bitmap.FromFile(drv["Imagine"].ToString());

                    // Adaugarea controlului nou creat la colectia de controale a containerului:
                    flowLayoutPanel1.Controls.Add(pictureBox);

                    // Adaugarea unui handler pentru evenimentul Click:
                    pictureBox.Click += pic_Click;
                }
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ((PictureBox)sender).Image;
        }

        private void cautareTextBox_TextChanged(object sender, EventArgs e)
        {
            string nume = cautareTextBox.Text;
            if (nume.Equals(string.Empty))
            {
                pacientiBindingSource.RemoveFilter();
            }
            else
            {
                pacientiBindingSource.Filter = "Nume = '" + nume + "'";
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
