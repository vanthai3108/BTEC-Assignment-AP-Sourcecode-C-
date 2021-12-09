using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    class ListBookFactory: IListFactory
    {
        public override IBasicMethod CreateListMethod()
        {
            return new ListBook();
        }
    }
}
