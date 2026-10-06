using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced01
{
    internal class ElectronicProduct : Product , IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Electronic product printed.");
        }
    }
}
