using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtpTest1
{
    class Produs
    {
        private string denumire;
        private string producator;
        private DateTime dataExpirare;
        private int pret;
        private int stoc;
        private Categorie categorie;

        public Produs(string denumire,string producator,DateTime dataExpirare,int pret,int stoc,Categorie categorie) {
            this.denumire = denumire;
            this.producator = producator;
            this.dataExpirare = dataExpirare;
            this.pret = pret;
            this.stoc = stoc;
            this.categorie = categorie;
        }

        public string Denumire { get => denumire; set => denumire = value; }
        public string Producator { get => producator; set => producator = value; }
        public DateTime DataExpirare { get => dataExpirare; set => dataExpirare = value; }
        public int Pret { get => pret; set => pret = value; }
        public int Stoc { get => stoc; set => stoc = value; }
        internal Categorie Categorie { get => categorie; set => categorie = value; }


    }

    enum Categorie : int {
        Legume,
        Fructe,
        Lactate
    };
}
