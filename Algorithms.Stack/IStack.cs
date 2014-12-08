using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Stack
{
    public interface IStack<TItem> : IEnumerable<TItem> where TItem : class
    {
        void Push(TItem item);
        TItem Pop();
        bool IsEmpty();
        int Size();
    }
}
