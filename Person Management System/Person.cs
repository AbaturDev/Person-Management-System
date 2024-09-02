using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagmentSystem
{
    internal abstract class Person
    {
        protected string name { get; set; }
        protected string surename { get; set; }
        protected string type { get; set; }
        protected string pesel;

        public Person() : this("Name", "Surename", "Person", "00000000000") { }
        public Person(string name, string surename, string type, string pesel)
        {
            this.name = name;
            this.surename = surename;
            this.type = type;
            this.pesel = pesel;
        }

        private bool isValidPesel(string pesel)
        {
            if(pesel.Length != 11)
            {
                return false;
            }
            return true;
        }

        public void setPesel(string pesel)
        {
            if(!isValidPesel(pesel))
            {
                Console.WriteLine("Incorrect pesel");
                return;
            }
            this.pesel = pesel;
        }
        public string getPesel()
        {
            return pesel;
        }

        public string getType()
        {
            return type;
        }

        public string getId()
        {
            return pesel;
        }

        public abstract void print();
    }
}
