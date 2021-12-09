using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    abstract class IListFactory
    {
        public abstract IBasicMethod CreateListMethod();
    }
}
