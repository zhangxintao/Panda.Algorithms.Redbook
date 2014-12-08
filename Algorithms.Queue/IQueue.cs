using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Queue
{
    public interface IQueue<TItem> : IEnumerable<TItem> where TItem : class
    {
        void Enqueue(TItem item);
        TItem Dequeue();
        bool IsEmpty();
        int Size();
    }
}
