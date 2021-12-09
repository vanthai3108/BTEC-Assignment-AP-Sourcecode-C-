using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a list to contain books and people
            IListFactory listBookFactory = new ListBookFactory();
            IBasicMethod listBook = listBookFactory.CreateListMethod();
            IListFactory listPersonFactory = new ListPersonFactory();
            IBasicMethod listPerson = listPersonFactory.CreateListMethod();

            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("####################### Menu ######################");
                    Console.WriteLine("     Enter 1: Manage Books");
                    Console.WriteLine("     Enter 2: Manage People");
                    Console.WriteLine("     Enter 3: Exit the program");
                    Console.WriteLine("###################################################");
                    Console.Write("Enter your selection: ");
                    int selection = int.Parse(Console.ReadLine());

                    switch (selection)
                    {
                        case 1:
                            // call the function to display and handle ListBook
                            listBook.Menu();
                            break;
                        case 2:
                            // call the function to display and handle ListPerson
                            listPerson.Menu();
                            break;
                        case 3:
                            // exit the program
                            Environment.Exit(0);
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
