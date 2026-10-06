using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced01
{
    internal class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }
}
