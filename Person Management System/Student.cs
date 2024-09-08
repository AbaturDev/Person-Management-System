using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagmentSystem
{
    internal class Student : Person
    {
        public string Index { get; set; }

        public Student() : this("Name", "Surename", "Student", "00000000000", "000000") { }
        public Student(string name, string surename, string type, string pesel, string index) : base(name, surename, type, pesel)
        {
            Index = index;
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} {Surename}, {Type} -> index: {Index}, pesel: {pesel}");
        }

        public override string ToString()
        {
            return Name + ";" + Surename + ";" + pesel + ";" + Index + ";" + Type;
        }
    }
}
