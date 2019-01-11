using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtpTest2FlowLayout
{
    class Echipament
    {
        private string nrInventar;
        private string model;
        private string an;
        private string categorie;
        private string responsabil;
        private string CNP;

        public Echipament(string nrInventar, string model, string an, string categorie, string responsabil, string cNP)
        {
            this.nrInventar = nrInventar;
            this.model = model;
            this.an = an;
            this.categorie = categorie;
            this.responsabil = responsabil;
            CNP = cNP;
        }

        public string NrInventar { get => nrInventar; set => nrInventar = value; }
        public string Model { get => model; set => model = value; }
        public string An { get => an; set => an = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Responsabil { get => responsabil; set => responsabil = value; }
        public string CNP1 { get => CNP; set => CNP = value; }

        public override string ToString()
        {
            return NrInventar +" "+ Model +" "+ An + " "+Categorie +" " +Responsabil+" " + CNP1;
        }
    }
}
