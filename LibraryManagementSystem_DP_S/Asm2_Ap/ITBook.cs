using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    // ITBook is inherited from class book.
    class ITBook : Book
    {
        // IT book's own properties.
        private string subject;

        // method to set, get private properties of IT book.
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        // Initialize IT Book with no parameters
        public ITBook() { }

        // Initialize IT Book with input parameter
        public ITBook(string id, string name, string author, long prices, string subject)
        {
            Id = id;
            Name = name;
            Author = author;
            Prices = prices;
            Subject = subject;
        }

        // The method of entering values for the IT book's properties via the keyboard,
        // override from book.
        public override void Input(string checkType, string id)
        {
            base.Input(checkType, id);
            Console.Write("Enter " + checkType + " Book subject: ");
            string subject = Console.ReadLine();
            Subject= subject;
        }

        // Method to display the value of the IT book's attributes via the keyboard
        // override from book.
        public override void Show()
        {
            base.Show();
            Console.WriteLine(" - Subject: " + subject + " - Belong to: IT Book");
        }
    }
}
