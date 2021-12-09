using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    //interface contains common methods of ListBook and ListPerson
    interface IBasicMethod
    {
        public void Add();
        public void Update();
        public void Delete();
        public void View();
        public void Search();
        public void Menu();
    }
}
