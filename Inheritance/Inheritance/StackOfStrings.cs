using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class StackOfStrings : Stack<string>
    {
        public bool IsEmpty() => Count == 0;       
        public void AddRange(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                Push(item);
            }
        }
    }
}
