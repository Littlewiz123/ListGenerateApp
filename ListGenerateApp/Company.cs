using System;
using System.Collections.Generic;
using System.Text;

namespace ListGenerateApp
{
    class Company : Population
    {
        public string CompanyName
        {
            get;
            set;
        }

        public override void SearchForPerson(string keyword)
        {
            List<Employee> filterList = new List<Employee>();
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].GetType() == typeof(Employee))
                {
                    var emId = ((Employee)People[i]).eid;
                    var department = ((Employee)People[i]).Department;
                    if (People[i].Name.ToLower().IndexOf(keyword) != -1)
                    {
                        filterList.Add(new Employee() { Name = People[i].Name, Age = People[i].Age, Birthbay = People[i].Birthbay, Children = People[i].Children, Gender = People[i].Gender, Parent = People[i].Parent, Department = department, eid = emId });
                    }
                }
            }
            Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", "Name", "Age", "Gender", "Birthday", "eId", "Department");
            filterList.ForEach((item) =>
            {
                Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", item.Name, item.Age, item.Gender, item.Birthbay.ToString().Substring(0, 10), item.eid, item.Department);
            });
        }

        public override void OrderByName()
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
            Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", "Name", "Age", "Gender", "Birthday", "eId", "Department");
            People.ForEach((item) =>
            {
                if (item.GetType() == typeof(Employee))
                {
                    var emId = ((Employee)item).eid;
                    var department = ((Employee)item).Department;
                    Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", item.Name, item.Age, item.Gender, item.Birthbay.ToString().Substring(0, 10), emId, department);
                }
            });
        }

        public override void OrderByAge()
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
            Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", "Name", "Age", "Gender", "Birthday", "eId", "Department");
            People.ForEach((item) =>
            {
                if (item.GetType() == typeof(Employee))
                {
                    var emId = ((Employee)item).eid;
                    var department = ((Employee)item).Department;
                    Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", item.Name, item.Age, item.Gender, item.Birthbay.ToString().Substring(0, 10), emId, department);
                }
            });
        }

        public override void filterMale()
        {
            List<Employee> filterMaleList = new List<Employee>();
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Gender.Trim() == "Male")
                {
                    if (People[i].GetType() == typeof(Employee))
                    {
                        var emId = ((Employee)People[i]).eid;
                        var department = ((Employee)People[i]).Department;
                        filterMaleList.Add(new Employee() { Name = People[i].Name, Age = People[i].Age, Birthbay = People[i].Birthbay, Children = People[i].Children, Gender = People[i].Gender, Parent = People[i].Parent, Department = department, eid = emId });
                    }
                }
            }
            Console.WriteLine(filterMaleList.Count);
            Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", "Name", "Age", "Gender", "Birthday", "eId", "Department");
            filterMaleList.ForEach((item) =>
            {
                Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", item.Name, item.Age, item.Gender, item.Birthbay.ToString().Substring(0, 10), item.eid, item.Department);
            });
        }

        public override void filterFemale()
        {
            List<Employee> filterFemaleList = new List<Employee>();
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Gender.Trim() == "Female")
                {
                    if (People[i].GetType() == typeof(Employee))
                    {
                        var emId = ((Employee)People[i]).eid;
                        var department = ((Employee)People[i]).Department;
                        filterFemaleList.Add(new Employee() { Name = People[i].Name, Age = People[i].Age, Birthbay = People[i].Birthbay, Children = People[i].Children, Gender = People[i].Gender, Parent = People[i].Parent, Department = department, eid = emId });
                    }
                }
            }
            Console.WriteLine(filterFemaleList.Count);
            Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", "Name", "Age", "Gender", "Birthday", "eId", "Department");
            filterFemaleList.ForEach((item) =>
            {
                Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", item.Name, item.Age, item.Gender, item.Birthbay.ToString().Substring(0, 10), item.eid, item.Department);
            });
        }
    }
}
