# Person Management System

The Person Management System is a simple console-based application written in C# for managing information about people, specific students and employees. This project was created as a learning tool for understanding the C# language, it's features and OOP principles.
The system allows you to add, remove, and display people in a list, save the list to a file, and load it from a file.

## Setup
1. Clone the repository
   ```bash
   git clone https://github.com/AbaturDev/Person-Management-System.git
   ```
2. Open the project in Visual Studio or any other C# development environment.
3. Build the solution to restore dependencies and compile the project.

## Usage
After compiling and running the project, you can interact with the system through the console interface.
### Example usage
1. **Adding a student or employee**: You can add students or employees to the list, by provading their properties.
2. **Displaying the list**: You can display the whole list or filter by students or employees.
3. **Finding person**: You can find and display student/employee by providing their pesel.
4. **File operations**: You can save/load the list from/to a text file.

### Sample Output
```
~~~~List of Persons~~~~
Jan Broski, Student -> index: 123456, pesel: 12345678901
Walter White, Student -> index: 272345, pesel: 10987654321
John Snow, Employee -> id: 33214, pesel: 00000000000
There are 3 people on the list
```

## Classes and Structure
* **Person(abstract)**: Represents a general person with properties such as `name`, `surname`, `pesel`, and `type`. The Person class is abstract and must be extended by specific types of people.
* **Student**: Extends `Person` and adds an `index` property specific to students.
* **Employee**: Extends `Person` and adds a `card_number` property specific to employees.
* **PersonList**: Manages a list of `Person` objects, providing methods to operate on a list. This class also handles file operations like saving to and loading from a text file.
