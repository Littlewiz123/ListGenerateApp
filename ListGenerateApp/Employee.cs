using System;
using System.Collections.Generic;
using System.Text;

namespace ListGenerateApp
{
    public interface ITalk
    {
        void Yell();
    }

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

        ITalk talk;
        public Employee(ITalk talk) => this.talk = talk;
        public void Yell() => talk.Yell();
    }

    public class BigYell : ITalk
    {
        public void Yell() => Console.WriteLine("Het to....");
    }

    public class SmallYell : ITalk
    {
        public void Yell() => Console.WriteLine("het  nho .....");
    }
}
