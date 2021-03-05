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

        protected List<Person> GetStudents()
        {
            List<Person> students = new List<Person>();
            if (People.Count > 0)
            {
                for (int n = 0; n < People.Count; n++)
                {
                    if (People[n].Age < 19 && People[n].Age > 4)
                    {
                        students.Add(new Person() { Name = People[n].Name, Age = People[n].Age, Gender = People[n].Gender });
                    }
                }
            }
            return students;
        }

        public List<Person> SearchForPeople(string keyword, List<Person> list)
        {
            List<Person> filterList = new List<Person>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name.ToLower().IndexOf(keyword) != -1)
                {
                    filterList.Add(new Person() { Name = list[i].Name, Birthbay = list[i].Birthbay, Age = list[i].Age, Gender = list[i].Gender });
                }
            }
            return filterList;
        }

        public List<Person> OrderByName(List<Person> list)
        {
            List<Person> listOrderByName = new List<Person>();
            for (int i = 0; i < list.Count; i++) //Compare Name method
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j].Name.CompareTo(list[j + 1].Name) > 0)
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return listOrderByName;
        }

        public List<Person> OrderByAge(List<Person> list)
        {
            List<Person> listOrderByAge = new List<Person>();
            for (int i = 0; i < list.Count; i++) //Compare Age method 
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j].Age.CompareTo(list[j + 1].Age) > 0)
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return listOrderByAge;
        }

        public List<Person> filterMale(List<Person> list)
        {
            List<Person> filterMaleList = new List<Person>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Gender == "Male")
                {
                    filterMaleList.Add(new Person() { Name = list[i].Name, Birthbay = list[i].Birthbay, Age = list[i].Age, Gender = list[i].Gender });
                }
            }
            return filterMaleList;
        }

        public List<Person> filterFemale(List<Person> list)
        {
            List<Person> filterFemaleList = new List<Person>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Gender == "Female")
                {
                    filterFemaleList.Add(new Person() { Name = list[i].Name, Birthbay = list[i].Birthbay, Age = list[i].Age, Gender = list[i].Gender });
                }
            }
            return filterFemaleList;
        }
    }
}
