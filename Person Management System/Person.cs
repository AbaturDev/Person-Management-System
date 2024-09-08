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
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Type { get; set; }

        protected string pesel;

        public Person() : this("Name", "Surename", "Person", "00000000000") { }
        public Person(string name, string surename, string type, string pesel)
        {
            Name = name;
            Surename = surename;
            Type = type;
            this.pesel = pesel;
        }

        /// <summary>
        /// Method to set pesel for person. Throw exception in case of wrong lenght of pesel
        /// </summary>
        /// <returns> 
        /// true - pesel is correct and has been set for object
        /// false - pesel is invalid 
        /// </returns>
        public bool SetPesel(string pesel)
        {
            if(pesel.Length > 11)
            {
                Console.WriteLine("Pesel is too long");
                return false;
            }
            else if(pesel.Length < 11)
            {
                Console.WriteLine("Pesel is too short");
                return false;
            }
            this.pesel = pesel;
            return true;
        }
        public string GetPesel()
        {
            return pesel;
        }

        public abstract void Print();
        public override abstract string ToString();

    }
}
