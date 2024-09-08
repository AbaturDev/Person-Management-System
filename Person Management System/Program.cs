using System;
using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using PersonManagmentSystem;

namespace ListOfPersons
{
    class Program
    {
        public static void Main(String[] args)
        {

            PersonList list = new PersonList();

            list.AddPerson(new Student("Jan", "Broski", "Student", "12345678901", "123456"));
            list.AddPerson(new Student("Walter", "White", "Student", "12345678901", "272345"));
            list.AddPerson(new Employee("John", "Snow", "Employee", "12345678901", "33214"));

            bool exit = false;

            while(!exit)
            {
                Console.WriteLine("~~~~Menu~~~~");
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. Add new employee");
                Console.WriteLine("3. Remove person by pesel");
                Console.WriteLine("4. Find person by pesel");
                Console.WriteLine("5. Display every person on the list");
                Console.WriteLine("6. Display all students");
                Console.WriteLine("7. Display all employees");
                Console.WriteLine("8. Save the list to file");
                Console.WriteLine("9. Load the list from file");
                Console.WriteLine("10. Exit");

                var input = Console.ReadLine();
                int choice;

                if(!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid value");
                    return;
                }

                switch (choice)
                {
                    case 1:
                        Student student = new Student();

                        Console.Write("Name: ");
                        student.Name = Console.ReadLine();

                        Console.Write("Surename: ");
                        student.Surename = Console.ReadLine();

                        Console.Write("Pesel: ");
                        if(!student.SetPesel(Console.ReadLine()))
                        {
                            break;
                        }

                        Console.Write("Index: ");
                        student.Index = Console.ReadLine();

                        list.AddPerson(student);

                        break;

                    case 2:
                        Employee employee = new Employee();

                        Console.Write("Name: ");
                        employee.Name = Console.ReadLine();

                        Console.Write("Surename: ");
                        employee.Surename = Console.ReadLine();

                        Console.Write("Pesel: ");
                        if(!employee.SetPesel(Console.ReadLine()))
                        {
                            break;
                        }

                        Console.Write("Card number: ");
                        employee.Card_Number = Console.ReadLine();

                        list.AddPerson(employee);

                        break;

                    case 3:
                        Console.WriteLine("Enter the pesel of the person");
                        var input_pesel = Console.ReadLine();
                        list.RemovePersonByPesel(input_pesel);
                        break;

                    case 4:
                        Console.WriteLine("Enter the pesel of the person");
                        var find = Console.ReadLine();
                        var find_person = list.GetPersonbyPesel(find);
                        find_person.Print();
                        
                        break;

                    case 5:
                        list.Display();
                        break;

                    case 6:
                        list.DisplayStudents();
                        break;

                    case 7:
                        list.DisplayEmployees();
                        break;

                    case 8:
                        list.SaveToFile();
                        Console.WriteLine("List has been saved");
                        break;

                    case 9:
                        list.LoadFromFile();
                        Console.WriteLine("List has been loaded");
                        break;

                    case 10:
                        exit = true;
                        break;


                    default:
                        Console.WriteLine("Operation does not exist! Try again");
                        break;

                }
                Console.WriteLine();
            }

        }
    }
}