using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    class Person
    {
        // general properties of person.
        protected string id;
        protected string name;
        protected int age;
        protected string gender;

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
        public int Age
        {
            get { return age; }
            set { if (value > 0 && value <= 150) { age = value; } }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value.ToLower() == "male")
                {
                    gender = "Male";
                }
                else if (value.ToLower() == "female")
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Unknown";

                }
            }
        }

        // The method of entering values for person properties via the keyboard.
        public virtual void Input(string checkType, string id)
        {
            Id = id;
            Console.Write("Enter " + checkType + " name: ");
            string name = Console.ReadLine();
            Name = name;
            Console.Write("Enter " + checkType + " age (0 - 150): ");
            int age = int.Parse(Console.ReadLine());
            Age = age;
            Console.Write("Enter " + checkType + " gender (Male/Female): ");
            string gender = Console.ReadLine();
            Gender = gender;
        }

        // Method to display the value of person attributes via the keyboard.
        public virtual void Show()
        {
            Console.Write("ID: " + id + " - Name: " + name + 
                            " - Age: " + age + " - Gender: " + gender);
        }
    }
}
