using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagmentSystem
{
    internal abstract class Person : Indefible
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

        /// <summary>
        /// Method to check if pesel is correct
        /// </summary>
        /// <param name="pesel"></param>
        /// <returns>
        /// "-1" - incorrect 
        /// "0" - correct
        /// </returns>
        public int setPesel(string pesel)
        {
            if(pesel.Length != 11)
            {
                //incorrect
                return -1;
            }
            this.pesel = pesel;
            return 0;   //correct
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

    }
}
