using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PersonManagmentSystem
{
    internal class PersonList
    {
        private List<Person> persons = new List<Person>();

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public void RemovePersonByPesel(string pesel)
        {
            Person temp = persons.FirstOrDefault( e => e.GetPesel() == pesel );
            persons.Remove(temp);
        }

        public Person GetPersonbyPesel(string pesel)
        {
            return persons.FirstOrDefault(e => e.GetPesel() == pesel);
        }

        public void Display()
        {
            Console.WriteLine("~~~~List of Persons~~~~");
            foreach (Person element in persons)
            {
                element.Print();
            }
            Console.WriteLine("There are " + GetPersonsCount() + " people on the list");
        }

        public void DisplayStudents()
        {
            Console.WriteLine("~~~~List of Students~~~~");
            List<Person> students = persons.Where(e => e.Type == "Student").ToList();
            foreach (Person element in students)
            {
                element.Print();
            }
            Console.WriteLine("There are " + GetStudentsCount() + " students on the list");
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("~~~~List of Employees~~~~");
            List<Person> students = persons.Where(e => e.Type == "Employee").ToList();
            foreach (Person element in students)
            {
                element.Print();
            }
            Console.WriteLine("There are " + GetEmployeeCount() + " employees on the list");

        }

        public int GetPersonsCount()
        {
            return persons.Count;
        }

        public int GetStudentsCount()
        {
            return persons.Where(e => e.Type == "Student").Count();
        }

        public int GetEmployeeCount()
        {
            return persons.Where(e => e.Type == "Employee").Count();
        }

        /// <summary>
        /// Method to save the list to the .txt file
        /// Method overrite the previous list(file)
        /// </summary>
        public void SaveToFile()
        {
            using(StreamWriter writer = new StreamWriter("list_file.txt", false))
            {
                foreach(var element in persons)
                {
                    writer.WriteLine(element.ToString());
                }
            }
        }

        /// <summary>
        /// Method to load the list from the file. Method add people from the file at the end of the current list.
        /// </summary>
        public void LoadFromFile()
        {
            if(!File.Exists("list_file.txt"))
            {
                Console.WriteLine("File does not exist! Save the list first");
                return;
            }

            List<Person> list = new List<Person>();

            using(StreamReader reader = new StreamReader("list_file.txt"))
            {
                string line = default;
                while ((line = reader.ReadLine()) != null)
                {
                    var temp_array = line.Split(";");

                    string name = temp_array[0];
                    string surename = temp_array[1];
                    string pesel = temp_array[2];
                    string id = temp_array[3];
                    string type = temp_array[4];

                    if(type == "Student")
                    {
                        list.Add(new Student(name, surename, type, pesel, id));
                    }
                    else if(type == "Employee")
                    {
                        list.Add(new Employee(name, surename, type, pesel, id));
                    }
                    else
                    {
                        throw new Exception("Error: Invalid type of Person. Can not load this type to the list");
                    }

                }
            }
            persons.AddRange(list);
        }
    }
}
