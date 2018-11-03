using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    class Persoana
    {
        protected string nume {get; set;}
        protected byte varsta {get; set;}

        public Persoana(string nume, byte varsta)
        {
            this.nume = nume;
            this.varsta = varsta;
        }
    }
}
