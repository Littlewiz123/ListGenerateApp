using System;
using System.Collections.Generic;
using System.Text;

namespace ListGenerateApp
{
    class Population
    {
        public int Size
        {
            get;
            set;
        }
        public List<Person> People
        {
            get;
            set;
        }

        //protected List<Person> GetStudents()
        //{
        //    List<Person> students = new List<Person>();
        //    if (People.Count > 0)
        //    {
        //        for (int n = 0; n < People.Count; n++)
        //        {
        //            if (People[n].Age < 19 && People[n].Age > 4)
        //            {
        //                students.Add(new Person() { Name = People[n].Name, Age = People[n].Age, Gender = People[n].Gender });
        //            }
        //        }
        //    }
        //    return students;
        //}

        public virtual void SearchForPerson(string keyword)
        {
            List<Person> filterList = new List<Person>();
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Name.ToLower().IndexOf(keyword) != -1)
                {
                    filterList.Add(new Person() { Name = People[i].Name, Age = People[i].Age, Birthbay = People[i].Birthbay, Children = People[i].Children, Gender = People[i].Gender, Parent = People[i].Parent});
                }
            }
            Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", "Name", "Age", "Gender", "Birthday");
            filterList.ForEach((item) =>
            {
                Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", item.Name, item.Age, item.Gender, item.Birthbay.ToString().Substring(0, 10));
            });
            //return filterList;
        }

        public virtual void OrderByName()
        {
            for (int i = 0; i < People.Count; i++) //Compare Name method
            {
                for (int j = 0; j < People.Count - 1; j++)
                {
                    if (People[j].Name.CompareTo(People[j + 1].Name) > 0)
                    {
                        var temp = People[j];
                        People[j] = People[j + 1];
                        People[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", "Name", "Age", "Gender", "Birthday");
            People.ForEach((item) =>
            {
                Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", item.Name, item.Age, item.Gender, item.Birthbay.ToString().Substring(0, 10));
            });
        }

        public virtual void OrderByAge()
        {
            for (int i = 0; i < People.Count; i++) //Compare Age method 
            {
                for (int j = 0; j < People.Count - 1; j++)
                {
                    if (People[j].Age.CompareTo(People[j + 1].Age) > 0)
                    {
                        var temp = People[j];
                        People[j] = People[j + 1];
                        People[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", "Name", "Age", "Gender", "Birthday");
            People.ForEach((item) =>
            {
                Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", item.Name, item.Age, item.Gender, item.Birthbay.ToString().Substring(0, 10));
            });
        }

        public virtual void filterMale()
        {
            List<Person> filterMaleList = new List<Person>();
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Gender.Trim() == "Male")
                {
                    filterMaleList.Add(new Person() { Name = People[i].Name, Birthbay = People[i].Birthbay, Age = People[i].Age, Gender = People[i].Gender });
                }
            }
            Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", "Name", "Age", "Gender", "Birthday");
            filterMaleList.ForEach((item) =>
            {
                Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", item.Name, item.Age, item.Gender, item.Birthbay.ToString().Substring(0, 10));
            });
        }

        public virtual void filterFemale()
        {
            List<Person> filterFemaleList = new List<Person>();
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Gender.Trim() == "Female")
                {
                    filterFemaleList.Add(new Person() { Name = People[i].Name, Birthbay = People[i].Birthbay, Age = People[i].Age, Gender = People[i].Gender });
                }
            }
            Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", "Name", "Age", "Gender", "Birthday");
            filterFemaleList.ForEach((item) =>
            {
                Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", item.Name, item.Age, item.Gender, item.Birthbay.ToString().Substring(0, 10));
            });
        }
    }
}
