using System;
using System.Numerics;
using PersonManagmentSystem;

namespace ListOfPersons
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Student("Walter", "White", "Student", "12345678901", "123456"));
        }
    }
}