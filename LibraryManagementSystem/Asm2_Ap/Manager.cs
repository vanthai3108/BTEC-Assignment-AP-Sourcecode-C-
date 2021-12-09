using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    // Manager is inherited from class person.
    class Manager: Person
    {
        // Manager's own properties.
        private string degree;

        // method to set, get private properties of manager.
        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        // Initialize reader with no parameters
        public Manager() { }

        // Initialize reader with input parameter
        public Manager(string id, string name, int age, string gender, string degree)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Degree = degree;
        }

        // The method of entering values for manager properties via the keyboard,
        // override from person.
        public override void Input(string checkType, string id)
        {
            base.Input(checkType, id);
            Console.Write("Enter " + checkType + " Degree: ");
            string degree = Console.ReadLine();
            Degree = degree;
        }

        // Method to display the value of manager attributes via the keyboard
        // override from person.
        public override void Show()
        {
            base.Show();
            Console.WriteLine(" - Degree: " + degree + " - Belong to: Manager");
        }
    }
}
