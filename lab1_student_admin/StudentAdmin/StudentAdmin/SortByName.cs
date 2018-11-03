using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    class SortByName : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return String.Compare(x.NumeStudent, y.NumeStudent);
        }
    }
}
