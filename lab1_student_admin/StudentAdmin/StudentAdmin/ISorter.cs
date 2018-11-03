using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    interface ISorter<T>
    {
        IEnumerable<T> Sorter(IEnumerable<T> items, IComparer<T> spec);
    }
}
