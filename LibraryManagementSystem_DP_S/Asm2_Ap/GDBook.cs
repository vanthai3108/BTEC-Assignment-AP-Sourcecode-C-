using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem

{   // GDBook is inherited from class book.
    class GDBook: Book
    {
        // GD book's own properties.
        private string level;

        // method to set, get private properties of GD book.
        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        // Initialize GD Book with no parameters
        public GDBook() { }

        // Initialize GD Book with input parameter
        public GDBook(string id, string name, string author, long prices, string level)
        {
            Id = id;
            Name = name;
            Author = author;
            Prices = prices;
            Level = level;
        }

        // The method of entering values for the GD book's properties via the keyboard,
        // override from book.
        public override void Input(string checkType, string id)
        {
            base.Input(checkType, id);
            Console.Write("Enter " + checkType + " Book level: ");
            string level = Console.ReadLine();
            Level = level;
        }

        // Method to display the value of the GD book's attributes via the keyboard
        // override from book.
        public override void Show()
        {
            base.Show();
            Console.WriteLine(" - Level: " + level + " - Belong to: GD Book");
        }
    }
}
