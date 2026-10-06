using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced01
{
    /*
Q9: What is the 'new()' constraint?

The 'new()' constraint specifies that T must have a public
parameterless constructor.
*/
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student()
        {
            Id = 0;
            Name = "Default Student";
        }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"Student Id: {Id}, Name: {Name}";
        }
    }
}
