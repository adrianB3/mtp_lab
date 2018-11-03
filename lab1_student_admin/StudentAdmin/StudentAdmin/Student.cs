using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    class Student : Persoana
    {
        private byte an;
        private byte[] note;

        public byte[] Note
        {
            get { return note; }
            set { note = value; }
        }
        
        public byte AnStudiu
        {
            get { return an; }
            set { an = value; }
        }

        public string NumeStudent
        {
            get { return nume; }
        }
        
        public Student(string NumeStudent, byte Varsta ,byte AnStudiu, byte[] Note):base(NumeStudent, Varsta)
        {
            this.an = AnStudiu;
            this.note = Note;
        }

        public float Medie()
        {
            float sum = 0;
            foreach(var nota in note){
                sum += nota;
            }

            return sum / note.Length;
        }

        public override string ToString()
        {
            var medie = this.Medie();
            return nume + ", " + varsta + " ani, " + "anul: " + an + ", Media: " + medie; 
        }
    }
}
