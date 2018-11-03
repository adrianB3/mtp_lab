using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    class Sorter : ISorter<Student>
    {
        IEnumerable<Student> ISorter<Student>.Sorter(IEnumerable<Student> items, IComparer<Student> spec)
        {
            foreach (var item in items)
            {
               
                yield return item;
                
            }
        }
    }
}
