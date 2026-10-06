using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced01
{
    internal class Container<T>
    {
        private T value;

        public void Add(T value)
        {
            this.value = value;
        }

        public T Get()
        {
            return value;
        }
    }
}
