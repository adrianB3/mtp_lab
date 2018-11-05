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

namespace lab4_lpf
{
    public partial class Form1 : Form
    {
        private List<Echipa> echipe = new List<Echipa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login_form lf = new login_form();
            if(lf.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                if(lf.DialogResult == DialogResult.Retry)
                {
                    MessageBox.Show("Utilizator sau Parola incorecte. Try Again.");
                    lf.ShowDialog();
                }
            }

            var directories = Directory.EnumerateDirectories("C:\\Users\\balan\\Documents\\mtp_lab\\lab4_lpf\\lab4_lpf\\Echipe");

            foreach (var directory in directories)
            {
                var dirInfo = new DirectoryInfo(directory).Name;
                echipa_comboBox.Items.Add(dirInfo);
                var files = Directory.EnumerateFiles("C:\\Users\\balan\\Documents\\mtp_lab\\lab4_lpf\\lab4_lpf\\Echipe\\" + dirInfo, "*.lpf");
                List<Jucator> jucatori = new List<Jucator>();
                foreach (var player in files)
                {
                    string nume = "";
                    string cnp = "";
                    Post post = Post.Atacant;
                    try
                    {   
                        using (StreamReader sr = new StreamReader(player))
                        {
                            string[] line = sr.ReadLine().Split(';');
                            nume = line[0];
                            post = (Post)Enum.Parse(typeof(Post), line[1]);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The file could not be read:");
                    }

                    jucatori.Add(new Jucator()
                    {
                        CNP = Path.GetFileNameWithoutExtension("C:\\Users\\balan\\Documents\\mtp_lab\\lab4_lpf\\lab4_lpf\\Echipe\\" + dirInfo + "\\" + new FileInfo(player).Name),
                        Nume = nume,
                        Post_Ocupat = post
                    });
                }

                echipe.Add(new Echipa(echipa_comboBox.Text, jucatori));
            }
        }

        private void adaugaEchipa_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (echipa_comboBox.Text.Equals(""))
                {
                    MessageBox.Show("Empty Input");
                }
                else
                {
                    var directories = Directory.EnumerateDirectories("C:\\Users\\balan\\Documents\\mtp_lab\\lab4_lpf\\lab4_lpf\\Echipe");

                    foreach (var directory in directories)
                    {
                        var dirInfo = new DirectoryInfo(directory).Name;
                        if (dirInfo.Equals(echipa_comboBox.Text))
                        {
                            MessageBox.Show("Echipa exista deja.");
                            throw new Exception();
                        }
                        else
                        {
                        }
                    }
                    Directory.CreateDirectory("C:\\Users\\balan\\Documents\\mtp_lab\\lab4_lpf\\lab4_lpf\\Echipe\\" + echipa_comboBox.Text);
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            var echipaSelectata = echipa_comboBox.Text;
            foreach (var echipa in echipe)
            {
                if (echipa.Denumire.Equals(echipaSelectata))
                {
                    foreach (var jucator in echipa.Jucators)
                    {
                        var butonJucator = new Button()
                        {
                            Text = jucator.Nume
                        };
                    }
                }
            }
        }
        private void adaugaJucator_button_Click(object sender, EventArgs e)
        {
            var ad = new adaugare_jucator_form(this);
            if(ad.ShowDialog() == DialogResult.Cancel)
            {
                ad.Close();
            }
            else
            {

            }
        }
    
    }
}
