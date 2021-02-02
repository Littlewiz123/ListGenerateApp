using System;
using System.Collections.Generic;
//using Npgsql;

namespace ListGenerateApp
{
    class Program
    {
        public static string GenRandomLastName()
        {
            List<string> lst = new List<string>();
            string str = string.Empty;
            lst.Add("Smith");
            lst.Add("Johnson");
            lst.Add("Williams");
            lst.Add("Jones");
            lst.Add("Brown");
            lst.Add("Davis");
            lst.Add("Miller");
            lst.Add("Wilson");
            lst.Add("Moore");
            lst.Add("Taylor");
            lst.Add("Anderson");
            lst.Add("Thomas");
            lst.Add("Jackson");
            lst.Add("White");
            lst.Add("Harris");
            lst.Add("Martin");
            lst.Add("Thompson");
            lst.Add("Garcia");
            lst.Add("Martinez");
            lst.Add("Robinson");
            lst.Add("Clark");
            lst.Add("Rodriguez");
            lst.Add("Lewis");
            lst.Add("Lee");
            lst.Add("Walker");
            lst.Add("Hall");
            lst.Add("Allen");
            lst.Add("Young");
            lst.Add("Hernandez");
            lst.Add("King");
            lst.Add("Wright");
            lst.Add("Lopez");
            lst.Add("Hill");
            lst.Add("Scott");
            lst.Add("Green");
            lst.Add("Adams");
            lst.Add("Baker");
            lst.Add("Gonzalez");
            lst.Add("Nelson");
            lst.Add("Carter");
            lst.Add("Mitchell");
            lst.Add("Perez");
            lst.Add("Roberts");
            lst.Add("Turner");
            lst.Add("Phillips");
            lst.Add("Campbell");
            lst.Add("Parker");
            lst.Add("Evans");
            lst.Add("Edwards");
            lst.Add("Collins");
            lst.Add("Stewart");
            lst.Add("Sanchez");
            lst.Add("Morris");
            lst.Add("Rogers");
            lst.Add("Reed");
            lst.Add("Cook");
            lst.Add("Morgan");
            lst.Add("Bell");
            lst.Add("Murphy");
            lst.Add("Bailey");
            lst.Add("Rivera");
            lst.Add("Cooper");
            lst.Add("Richardson");
            lst.Add("Cox");
            lst.Add("Howard");
            lst.Add("Ward");
            lst.Add("Torres");
            lst.Add("Peterson");
            lst.Add("Gray");
            lst.Add("Ramirez");
            lst.Add("James");
            lst.Add("Watson");
            lst.Add("Brooks");
            lst.Add("Kelly");
            lst.Add("Sanders");
            lst.Add("Price");
            lst.Add("Bennett");
            lst.Add("Wood");
            lst.Add("Barnes");
            lst.Add("Ross");
            lst.Add("Henderson");
            lst.Add("Coleman");
            lst.Add("Jenkins");
            lst.Add("Perry");
            lst.Add("Powell");
            lst.Add("Long");
            lst.Add("Patterson");
            lst.Add("Hughes");
            lst.Add("Flores");
            lst.Add("Washington");
            lst.Add("Butler");
            lst.Add("Simmons");
            lst.Add("Foster");
            lst.Add("Gonzales");
            lst.Add("Bryant");
            lst.Add("Alexander");
            lst.Add("Russell");
            lst.Add("Griffin");
            lst.Add("Diaz");
            lst.Add("Hayes");
            Random rnd = new Random();
            return lst[rnd.Next(0, lst.Count)];
        }

        static string GetRandomGender()
        {
            string[] genders = new string[] { "Male", "Female" };
            Random rand = new Random();
            int index = rand.Next(genders.Length);
            string gender = genders[index];
            return gender;
        }

        static void Main(string[] args)
        {
            List<Employee> listEmployee = new List<Employee>();
            List<Employee> saveListEmployee = new List<Employee>();
            Console.WriteLine("Enter quantity of employees to save to Database: ");
            int numberSave = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberSave; i++)
            {
                Random r = new Random();
                string id = i.ToString();
                int randAge = r.Next(18, 30);
                string randName = GenRandomLastName();
                string randGender = GetRandomGender();
                
                listEmployee.Add(new Employee(id, randName, randAge, randGender));
            }
            listEmployee.ForEach((item) => {
                saveListEmployee.Add(item);
            });
            int option;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Select Number Options");
                Console.WriteLine("1 - Search by Name");
                Console.WriteLine("2 - Order list by User Name");
                Console.WriteLine("3 - Order list by Age");
                Console.WriteLine("4 - Filter list only Male");
                Console.WriteLine("5 - Filter list only Female");
                Console.WriteLine("Press any key to exit menu!");
                option = int.Parse(Console.ReadLine());
                if (option >= 6)
                {
                    System.Environment.Exit(1);
                }
                else 
                {
                    switch (option)
                    {
                        case (1):
                            Console.WriteLine("Enter keyword");
                            string text = Console.ReadLine().ToLower();
                            List<Employee> filterList = saveListEmployee.FindAll(employee => employee.Name.ToLower().IndexOf(text.ToLower()) != -1);
                            if (filterList.Count > 0)
                                foreach (var employee in filterList)
                                {
                                    Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Age + " " + employee.Gender);
                                }
                            break;
                        case (2):
                            saveListEmployee.Sort((e1, e2) => e1.Name.CompareTo(e2.Name));
                            foreach (var employee in saveListEmployee)
                            {
                                Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Age + " " + employee.Gender);
                            }
                            break;
                        case (3):
                            saveListEmployee.Sort((em1, em2) => {
                                if (em1.Age > em2.Age)
                                    return 1;
                                else if (em1.Age == em2.Age)
                                    return 0;
                                return -1;
                            });
                            foreach (var employee in saveListEmployee)
                            {
                                Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Age + " " + employee.Gender);
                            }
                            break;
                        case (4):
                            List<Employee> filterMaleList = saveListEmployee.FindAll(employee => employee.Gender.ToLower() == "Male".ToLower());
                            foreach (var employee in filterMaleList)
                            {
                                Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Age + " " + employee.Gender);
                            }
                            break;
                        case (5):
                            List<Employee> filterFemaleList = saveListEmployee.FindAll(employee => employee.Gender.ToLower() == "Female".ToLower());
                            foreach (var employee in filterFemaleList)
                            {
                                Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Age + " " + employee.Gender);
                            }
                            break;
                        default:
                            break;
                    }
                }
            } while (option < 5);
        }
    }
}
