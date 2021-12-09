using System;

namespace Sigleton
{
    public sealed class Leader
    {
        private string id;
        private string name;
        private int age;
        private string gender;
        private string position = "Leader";
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
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private static Leader instance = null;

        private Leader() { }

        public static Leader Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Leader();
                }
                return instance;
            }
        }
        
        public void SetInfo(string id, string name, int age, string gender)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void GetInfo()
        {
            Console.WriteLine("Leader info:");
            Console.WriteLine("ID: " + id + " - Name: " + name + " - Age: " + age 
                            + " - Gender: " + gender + " - Position: " + position);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Leader leader = Leader.Instance;

            Console.WriteLine("Current Leader: ");
            leader.SetInfo("LD01", "Mai Van A", 19, "Male");
            leader.GetInfo();

            Console.WriteLine();
            Console.WriteLine("Change Leader! ");
            Console.WriteLine("New Leader:");
            leader.SetInfo("LD02", "Mai Van B", 20, "Male");
            leader.GetInfo();
        }
    }
}
