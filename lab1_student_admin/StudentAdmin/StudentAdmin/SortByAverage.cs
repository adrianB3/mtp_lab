using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    class SortByAverage : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Medie() < y.Medie())
                return 1;
            if (x.Medie() > y.Medie())
                return -1;
            return 0;
        }
    }
}
