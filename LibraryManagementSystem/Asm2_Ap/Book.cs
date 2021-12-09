using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    class Book
    {
        // general properties of book.
        protected string id;
        protected string name;
        protected string author;
        protected long prices;

        // methods to set, get property.
        public string Id
        {
            get { return id; }   
            set { id = value; }  
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public long Prices
        {
            get { return prices; }
            set { if (value > 0) { prices = value; } } 
        }

        // The method of entering values for the book's properties via the keyboard.
        public virtual void Input(string checkType, string id)
        {
            Id = id;
            Console.Write("Enter "+ checkType + " Book name: ");
            string name = Console.ReadLine();
            Name = name;
            Console.Write("Enter "+ checkType + " Book author: ");
            string author = Console.ReadLine();
            Author = author;
            Console.Write("Enter " + checkType + " Book prices: ");
            long prices = long.Parse(Console.ReadLine());
            Prices = prices;
        }

        // Method to display the value of the book's attributes via the keyboard.
        public virtual void Show()
        {
            Console.Write("ID: " + id + " - Name: " + name + 
                            " - Author: " + author + " - Prices: " + prices);
        }
    }
}
