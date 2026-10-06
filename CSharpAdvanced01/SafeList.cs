using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced01
{
    internal class SafeList<T>
    {

        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= items.Count)
                {
                    return default(T);
                }
                return items[index];
            }
        }
    }
}
