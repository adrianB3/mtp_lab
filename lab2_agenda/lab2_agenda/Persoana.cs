using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_agenda
{
    enum Categorie : int
    {
        Prieteni,
        Colegi,
        Rude,
        Diversi
    }
    class Persoana
    {
        private int uid;
        private string nume;
        private DateTime dataNasterii;
        private string numarTelefon;
        private string adresa;
        private Categorie categorie;

        public Persoana(int uid,string nume, DateTime dataNasterii, string numarTelefon, string adresa, Categorie categorie)
        {
            this.uid = uid;
            this.nume = nume;
            this.dataNasterii = dataNasterii;
            this.numarTelefon = numarTelefon;
            this.adresa = adresa;
            this.categorie = categorie;
        }

        [Description("Numele complet al persoanei"), Category("Date personale")]
        public string Nume => nume;
        [Description("Data Nasterii"), Category("Date personale")]
        public DateTime DataNasterii => dataNasterii;
        [Description("Telefon"), Category("Date de contact")]
        public string NumarTelefon { get => numarTelefon; set { numarTelefon = value; } }
        [Description("Adresa"), Category("Date de contact")]
        public string Adresa { get => adresa; set { adresa = value; } }
        [Description("Categorie"), Category("Date personale")]
        public Categorie Categorie { get => categorie; set { categorie = value; } }
        [Description("Index"), Browsable(false)]
        public int Uid { get { return uid; } }
    }
}
