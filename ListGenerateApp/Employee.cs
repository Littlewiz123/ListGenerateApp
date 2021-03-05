using System;
using System.Collections.Generic;
using System.Text;

namespace ListGenerateApp
{
    class Employee : Person
    {
        public int UId
        {
            get;
            set;
        }

        public List<Person> Children
        {
            get;
            set;
        }
    }
}
