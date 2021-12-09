using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    // Reader is inherited from class book.
    class Reader : Person
    {
        // Reader's own properties.
        private string type;

        // method to set, get private properties of reader.
        public string Type
        {
            get { return type; }
            set
            {
                if (value.ToLower() == "internal")
                {
                    type = "Internal";
                }
                else if (value.ToLower() == "external")
                {
                    type = "External";
                }
                else
                {
                    type = "Unknown";

                }
            }
        }

        // Initialize reader with no parameters
        public Reader() { }

        // Initialize reader with input parameter
        public Reader(string id, string name, int age, string gender, string type)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Type = type;
        }

        // The method of entering values for reader properties via the keyboard,
        // override from person.
        public override void Input(string checkType, string id)
        {
            base.Input(checkType, id);
            Console.Write("Enter " + checkType + " type (Internal/External): ");
            string type = Console.ReadLine();
            Type = type;
        }

        // Method to display the value of reader attributes via the keyboard
        // override from person.
        public override void Show()
        {
            base.Show();
            Console.WriteLine(" - Type: " + type + " - Belong to: Reader");
        }
    }
}
