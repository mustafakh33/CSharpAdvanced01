using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced01
{
    internal interface IRepository<T>
    {
        void Add(T item);

        T GetById(int id);

        void Remove(int id);
    }
}
