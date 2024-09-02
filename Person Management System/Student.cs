using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagmentSystem
{
    internal class Student : Person
    {
        private string index { get; set; }

        public Student() : this("Name", "Surename", "Student", "00000000000", "000000") { }
        public Student(string name, string surename, string type, string pesel, string index) : base(name, surename, type, pesel)
        {
            this.index = index;
        }

        public override void print()
        {
            Console.WriteLine($"{name} {surename}, {type} -> index: {index}, pesel: {pesel}");
        }
    }
}
