using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    class ListPersonFactory: IListFactory
    {
        public override IBasicMethod CreateListMethod()
        {
            return new ListPerson();
        }
    }
}
