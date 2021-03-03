using System;
using System.Collections.Generic;
using System.Text;

namespace ListGenerateApp
{
    class Parent : Person
    {
        public List<Person> Children
        {
            get;
            set;
        }
    }
}
