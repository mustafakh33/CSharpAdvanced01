using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced01
{
    internal class Employee : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Employee printed.");
        }
    }
}
