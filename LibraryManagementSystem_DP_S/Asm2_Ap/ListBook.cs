using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    // Using the methods in IBasicMethod interface
    class ListBook : IBasicMethod
    {
        // Initialize a list containing Books
        public List<Book> books = new List<Book>();

        // Method to add a book to the list
        public void Add()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>> Add a new Book <<<<<<<<<<<<<<<<<");
            Console.Write("Enter Book id (IT Book: IT... - GD Book: GD...): ");
            string id = Console.ReadLine().ToUpper();
            bool check_exit = false;
            foreach (Book book in books)
            {
                if (book.Id == id)
                {
                    check_exit = true;
                    break;
                }
            }
            if (check_exit != true)
            {
                try
                {
                    if (id.StartsWith("IT"))
                    {
                        Book itbook = new ITBook();
                        itbook.Input("IT", id);
                        books.Add(itbook);
                        Console.WriteLine("Add new IT Book successful!");
                    }
                    else if (id.StartsWith("GD"))
                    {
                        Book gdbook = new GDBook();
                        gdbook.Input("GD", id);
                        books.Add(gdbook);
                        Console.WriteLine("Add new GD Book successful!");
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
            else
            {
                Console.WriteLine("Add failed. Book id already exist!");
            }
        }

        // Method to update a book in the list
        public void Update()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>> Update a Book <<<<<<<<<<<<<<<<<");
            Console.Write("Enter book id: ");
            string id = Console.ReadLine().ToUpper();
            bool check_exist = false;
            int count_index = -1;
            foreach (Book book in books)
            {
                count_index++;
                if (book.Id == id)
                {
                    check_exist = true;
                    break;
                }
            }
            if (check_exist)
            {
                try
                {
                    Console.WriteLine("Update book infnormation:");
                    Console.Write("Enter Book name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Book author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter Book prices: ");
                    long prices = long.Parse(Console.ReadLine());
                    if (id.StartsWith("IT"))
                    {
                        Console.Write("Enter IT Book subject: ");
                        string subject = Console.ReadLine();
                        Book itbook = new ITBook(id, name, author, prices, subject);
                        books[count_index] = itbook;
                        Console.WriteLine("Update IT Book successful!");
                    }
                    else
                    {
                        Console.Write("Enter GD Book level: ");
                        string level = Console.ReadLine();
                        Book gdbook = new GDBook(id, name, author, prices, level);
                        books[count_index] = gdbook;
                        Console.WriteLine("Update GD Book successful!");
                    }
                }
                catch
                {
                    Console.WriteLine("Update failed. Invalid information entered!");
                }
            }
            else
            { 
                Console.WriteLine("Update failed. There is no book with id = " + id);
            }
        }

        // Method to delete a book in the list
        public void Delete()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>> Delete a Book <<<<<<<<<<<<<<<<<<<");
            Console.Write("Enter IT Book id: ");
            string id = Console.ReadLine().ToUpper();
            bool check_exist = false;
            foreach (Book book in books)
            {
                if (book.Id == id)
                {
                    check_exist = true;
                    books.Remove(book);
                    Console.WriteLine("Delete Book successful!");
                    break;
                }
            }
            if (!check_exist)
            {
                Console.WriteLine("Delete failed. There is no book with id = " + id);
            }
        }

        // Method to view all books in the list
        public void View()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>> View all books <<<<<<<<<<<<<<<<<");
            if (books.Count != 0)
            {
                foreach (Book book in books)
                {
                    book.Show();
                }
            }
            else
            {
                Console.WriteLine("There are no books in library!");
            }
        }

        // Method to search books in the list
        public void Search()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>> Search books <<<<<<<<<<<<<<<<<<");
            Console.Write("Enter keyword: ");
            string keyword = Console.ReadLine().ToLower();
            bool check_exist = false;
            foreach (Book book in books)
            {
                string name = book.Name.ToLower();
                if (name.Contains(keyword))
                {
                    check_exist = true;
                    book.Show();
                }
            }
            if (!check_exist)
            {
                Console.WriteLine("There is no Book with name containing " + keyword);
            }
        }

        // Methods to display the Manage books menu and the above handling methods.
        public void Menu()
        {
            bool bookMenu = true;
            while (bookMenu)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("----------------- Manage Book menu ----------------");
                    Console.WriteLine("     Enter 1: View all books");
                    Console.WriteLine("     Enter 2: Search books");
                    Console.WriteLine("     Enter 3: Add a new book ");
                    Console.WriteLine("     Enter 4: Update a book");
                    Console.WriteLine("     Enter 5: Delete a book");
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
                            bookMenu = false;
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
