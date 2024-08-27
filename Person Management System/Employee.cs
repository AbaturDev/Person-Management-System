using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagmentSystem
{
    internal class Employee : Person
    {
        private string card_number { get; set; }

        public Employee() : this("Name", "Surename", "Employee", "00000000000", "000000") { }
        public Employee(string name, string surename, string type, string pesel, string card_number) : base(name, surename, type, pesel)
        {
            this.card_number = card_number;
        }
    }
}
