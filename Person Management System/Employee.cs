using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagmentSystem
{
    internal class Employee : Person
    {
        public string Card_Number { get; set; }

        public Employee() : this("Name", "Surename", "Employee", "00000000000", "000000") { }
        public Employee(string name, string surename, string type, string pesel, string card_number) : base(name, surename, type, pesel)
        {
            Card_Number = card_number;
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} {Surename}, {Type} -> id: {Card_Number}, pesel: {pesel}");
        }

        public override string ToString()
        {
            return Name + ";" + Surename + ";" + pesel + ";" + Card_Number + ";" + Type;
        }
    }
}
