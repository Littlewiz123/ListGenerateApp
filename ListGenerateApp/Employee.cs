using System;
using System.Collections.Generic;
using System.Text;

namespace ListGenerateApp
{
    class Employee
    {
        public string id;
        public string name;
        public int age;
        public string gender;

        public Employee(string Id, string Name, int Age, string Gender)
        {
            this.id = Id;
            this.name = Name;
            this.age = Age;
            this.gender = Gender;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
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
    }
}
