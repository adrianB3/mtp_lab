using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_lpf
{
    class Echipa
    {
        private string denumire;
        private List<Jucator> jucatori = new List<Jucator>();

        public string Denumire { get { return denumire; } set { this.denumire = value; } }
        public List<Jucator> Jucators { get { return jucatori; } set { this.jucatori = value; } }

        public Echipa(string denumire, List<Jucator> jucatori)
        {
            this.denumire = denumire ?? throw new ArgumentNullException(nameof(denumire));
            this.jucatori = jucatori ?? throw new ArgumentNullException(nameof(jucatori));
        }
        public Echipa() { }
    }
}
