using System;
using System.Numerics;
using PersonManagmentSystem;

namespace ListOfPersons
{
    class Program
    {
        public static void Main(String[] args)
        {
            PersonList list = new PersonList();
            list.addPerson(new Student("Walter", "White", "Student", "12345678901", "123456"));

            list.display();

            bool exit = true;

            while(exit)
            {
                Console.WriteLine("~~~~Menu~~~~");
                Console.WriteLine("Select operation 1-6");
                Console.WriteLine("1. Add person");
                Console.WriteLine("2. Remove person by pesel");
                Console.WriteLine("3. Find person by pesel");
                Console.WriteLine("4. Display every person on the list");
                Console.WriteLine("5. Display all students");
                Console.WriteLine("6. Display all employees");

                //tbc
            }

        }
    }
}