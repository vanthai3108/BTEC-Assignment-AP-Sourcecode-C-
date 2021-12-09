using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    // Using the methods in IBasicMethod interface
    class ListPerson : IBasicMethod
    {
        // Initialize a list containing People
        public List<Person> people = new List<Person>();

        // Method to add a person to the list
        public void Add()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>> Add a new person <<<<<<<<<<<<<<<<");
            Console.Write("Enter person id (Manager: MG... - Reader: RD...): ");
            string id = Console.ReadLine().ToUpper();
            bool check_exit = false;

            foreach (Person person in people)
            {
                if (person.Id.StartsWith("MG") && id.StartsWith("MG"))
                {
                    check_exit = true;
                    Console.WriteLine("There is already a manager in the system, can't add more.");
                    break;
                }
                if (person.Id == id)
                {
                    check_exit = true;
                    Console.WriteLine("Add failed. Person id already exist!");
                    break;
                } 
            }
            if (check_exit != true)
            {
                try
                {
                    if (id.StartsWith("MG"))
                    {
                        Person manage = new Manager();
                        manage.Input("manager", id);
                        people.Add(manage);
                        Console.WriteLine("Add new manager successful!");

                    }
                    else if (id.StartsWith("RD"))
                    {
                        Person reader = new Reader();
                        reader.Input("reader", id);
                        people.Add(reader);
                        Console.WriteLine("Add new reader successful!");
                    }
                    else
                    {
                        Console.Write("Add failed. Invalid ID");
                    }
                }
                catch
                {
                    Console.WriteLine("Add failed. Invalid information entered!");
                }
            }
        }

        // Method to update a person in the list
        public void Update()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>> Update a person <<<<<<<<<<<<<<<<<");
            Console.Write("Enter person id: ");
            string id = Console.ReadLine().ToUpper();
            bool check_exist = false;
            int count_index = -1;
            foreach (Person person in people)
            {
                count_index++;
                if (person.Id == id)
                {
                    check_exist = true;
                    break;
                }
            }

            if (check_exist)
            {
                try
                {
                    Console.WriteLine("Update person infnormation:");
                    Console.Write("Enter person name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter person age (0 - 150): ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter person gender (Male/Female): ");
                    string gender = Console.ReadLine();
                    if (id.StartsWith("RD"))
                    {
                        Console.Write("Enter reader type (Internal/External): ");
                        string type = Console.ReadLine();
                        Person reader = new Reader(id, name, age, gender, type);
                        people[count_index] = reader;
                        Console.WriteLine("Update reader successful!");
                    }
                    else
                    {
                        Console.Write("Enter manager degree: ");
                        string degree = Console.ReadLine();
                        Person manager = new Manager(id, name, age, gender, degree);
                        people[count_index] = manager;
                        Console.WriteLine("Update manager successful!");
                    }
                }
                catch
                {
                    Console.WriteLine("Update failed. Invalid information entered!");
                }
            }
            else
            {
                Console.WriteLine("Update failed. There is no person with id = " + id);
            }
        }

        // Method to delete a person in the list
        public void Delete()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>> Delete a person <<<<<<<<<<<<<<<<<");
            Console.Write("Enter person id: ");
            string id = Console.ReadLine().ToUpper();
            bool check_exist = false;
            foreach (Person person in people)
            {
                if (person.Id == id)
                {
                    check_exist = true;
                    people.Remove(person);
                    Console.WriteLine("Delete reader successful!");
                    break;
                }
            }
            if (!check_exist)
            {
                Console.WriteLine("Delete failed. There is person with id = " + id);
            }

        }

        // Method to view all people in the list
        public void View()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>> View all people <<<<<<<<<<<<<<<<<");
            if (people.Count != 0)
            {
                foreach (Person person in people)
                {
                    person.Show();
                }
            }
            else
            {
                Console.WriteLine("There are no readers in library!");
            }
        }

        // Method to search people in the list
        public void Search()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>> Search people <<<<<<<<<<<<<<<<<<");
            Console.Write("Enter keyword: ");
            string keyword = Console.ReadLine().ToLower();
            bool check_exist = false;
            foreach (Person person in people)
            {
                string name = person.Name.ToLower();
                if (name.Contains(keyword))
                {
                    check_exist = true;
                    person.Show();
                }
            }
            if (!check_exist)
            {
                Console.WriteLine("There is no reader with name containing " + keyword);
            }
        }

        // Methods to display the Manage people menu and the above handling methods.
        public void Menu()
        {
            bool peopleMenu = true;
            while (peopleMenu)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("---------------- Manage People Menu ---------------");
                    Console.WriteLine("     Enter 1: View all people");
                    Console.WriteLine("     Enter 2: Search people");
                    Console.WriteLine("     Enter 3: Add a new person");
                    Console.WriteLine("     Enter 4: Update a person");
                    Console.WriteLine("     Enter 5: Delete a person");
                    Console.WriteLine("     Enter 6: Back to main menu");
                    Console.WriteLine("---------------------------------------------------");
                    Console.Write("Enter your selection: ");
                    int selection = int.Parse(Console.ReadLine());
                    switch (selection)
                    {
                        case 1:
                            View();
                            break;
                        case 2:
                            Search();
                            break;
                        case 3:
                            Add();
                            break;
                        case 4:
                            Update();
                            break;
                        case 5:
                            Delete();
                            break;
                        case 6:
                            peopleMenu = false;
                            break;
                        default:
                            Console.WriteLine("Invalid selection!");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid selection!");
                }
            }
        }
    }
}
