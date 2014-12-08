using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Bag
{
    public interface IBag<TItem> : IEnumerable<TItem> where TItem : class
    {
        void Add(TItem item);
        bool IsEmpty();
        int Size();
    }
}
