using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagmentSystem
{
    internal abstract class Person
    {
        public string name { get; set; }
        public string surename { get; set; }
        public string type { get; set; }

        protected string pesel;

        public Person() : this("Name", "Surename", "Person", "00000000000") { }
        public Person(string name, string surename, string type, string pesel)
        {
            this.name = name;
            this.surename = surename;
            this.type = type;
            this.pesel = pesel;
        }

        /// <summary>
        /// Method to set pesel for person. Throw exception in case of wrong lenght of pesel
        /// </summary>
        public void setPesel(string pesel)
        {
            if(pesel.Length > 11)
            {
                throw new Exception("Pesel is too long");
            }
            else if(pesel.Length < 11)
            {
                throw new Exception("Pesel is too short");
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

        public abstract void print();
        public override abstract string ToString();

    }
}
