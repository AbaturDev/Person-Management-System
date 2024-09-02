using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagmentSystem
{
    internal class PersonList
    {
        private List<Person> persons = new List<Person>();

        public void addPerson(Person person)
        {
            persons.Add(person);
        }

        public void removePersonByPesel(string pesel)
        {
            Person temp = persons.FirstOrDefault( e => e.getPesel() == pesel );
            persons.Remove(temp);
        }

        public Person getPersonbyPesel(string pesel)
        {
            return persons.FirstOrDefault(e => e.getPesel() == pesel);
        }

        public void display()
        {
            Console.WriteLine("~~~~List of Persons~~~~");
            foreach (Person element in persons)
            {
                element.print();
            }
            Console.WriteLine("\tThere are" + getPersonsCount() + " people on the list");
        }

        public void displayStudents()
        {
            Console.WriteLine("~~~~List of Students~~~~");
            List<Person> students = persons.Where(e => e.getType() == "Student").ToList();
            foreach (Person element in students)
            {
                element.print();
            }
            Console.WriteLine("\tThere are" + getStudentsCount() + " students on the list");
        }

        public void displayEmployees()
        {
            Console.WriteLine("~~~~List of Employees~~~~");
            List<Person> students = persons.Where(e => e.getType() == "Employee").ToList();
            foreach (Person element in students)
            {
                element.print();
            }
            Console.WriteLine("\tThere are" + getEmployeeCount() + " employees on the list");

        }

        public int getPersonsCount()
        {
            return persons.Count;
        }

        public int getStudentsCount()
        {
            return persons.Where(e => e.getType() == "Student").Count();
        }

        public int getEmployeeCount()
        {
            return persons.Where(e => e.getType() == "Employee").Count();
        }

        /*
         To add:
        save and load from the file
         */
    }
}
