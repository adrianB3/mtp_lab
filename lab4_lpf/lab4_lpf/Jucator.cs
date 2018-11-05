using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_lpf
{
    class Jucator
    {
        private string cnp;
        private string nume;
        private Post post_ocupat;

        public string CNP { get { return cnp; } set { this.cnp = value; } }
        public string Nume { get { return nume; } set { this.nume = value; } }
        public Post Post_Ocupat { get { return post_ocupat; } set { this.post_ocupat = value; } }

        public Jucator(string cnp, string nume, Post post_ocupat)
        {
            this.cnp = cnp;
            this.nume = nume;
            this.post_ocupat = post_ocupat;
        }
        public Jucator() { }
    }
}
