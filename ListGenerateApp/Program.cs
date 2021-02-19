using System;
using System.Collections.Generic;
using Npgsql;

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

        public static string GenRandomFirstName()
        {
            List<string> lst = new List<string>();
            string str = string.Empty;
            lst.Add("Aiden");
            lst.Add("Jackson");
            lst.Add("Mason");
            lst.Add("Liam");
            lst.Add("Jacob");
            lst.Add("Jayden");
            lst.Add("Ethan");
            lst.Add("Noah");
            lst.Add("Lucas");
            lst.Add("Logan");
            lst.Add("Caleb");
            lst.Add("Caden");
            lst.Add("Jack");
            lst.Add("Ryan");
            lst.Add("Connor");
            lst.Add("Michael");
            lst.Add("Elijah");
            lst.Add("Brayden");
            lst.Add("Benjamin");
            lst.Add("Nicholas");
            lst.Add("Alexander");
            lst.Add("William");
            lst.Add("Matthew");
            lst.Add("James");
            lst.Add("Landon");
            lst.Add("Nathan");
            lst.Add("Dylan");
            lst.Add("Evan");
            lst.Add("Luke");
            lst.Add("Andrew");
            lst.Add("Gabriel");
            lst.Add("Gavin");
            lst.Add("Joshua");
            lst.Add("Owen");
            lst.Add("Daniel");
            lst.Add("Carter");
            lst.Add("Tyler");
            lst.Add("Cameron");
            lst.Add("Christian");
            lst.Add("Wyatt");
            lst.Add("Henry");
            lst.Add("Eli");
            lst.Add("Joseph");
            lst.Add("Max");
            lst.Add("Isaac");
            lst.Add("Samuel");
            lst.Add("Anthony");
            lst.Add("Grayson");
            lst.Add("Zachary");
            lst.Add("David");
            lst.Add("Christopher");
            lst.Add("John");
            lst.Add("Isaiah");
            lst.Add("Levi");
            lst.Add("Jonathan");
            lst.Add("Oliver");
            lst.Add("Chase");
            lst.Add("Cooper");
            lst.Add("Tristan");
            lst.Add("Colton");
            lst.Add("Austin");
            lst.Add("Colin");
            lst.Add("Charlie");
            lst.Add("Dominic");
            lst.Add("Parker");
            lst.Add("Hunter");
            lst.Add("Thomas");
            lst.Add("Alex");
            lst.Add("Ian");
            lst.Add("Jordan");
            lst.Add("Cole");
            lst.Add("Julian");
            lst.Add("Aaron");
            lst.Add("Carson");
            lst.Add("Miles");
            lst.Add("Blake");
            lst.Add("Brody");
            lst.Add("Adam");
            lst.Add("Sebastian");
            lst.Add("Adrian");
            lst.Add("Nolan");
            lst.Add("Sean");
            lst.Add("Riley");
            lst.Add("Bentley");
            lst.Add("Xavier");
            lst.Add("Hayden");
            lst.Add("Jeremiah");
            lst.Add("Jason");
            lst.Add("Jake");
            lst.Add("Asher");
            lst.Add("Micah");
            lst.Add("Jace");
            lst.Add("Brandon");
            lst.Add("Josiah");
            lst.Add("Hudson");
            lst.Add("Nathaniel");
            lst.Add("Bryson");
            lst.Add("Ryder");
            lst.Add("Justin");
            lst.Add("Bryce");

            //—————female

            lst.Add("Sophia");
            lst.Add("Emma");
            lst.Add("Isabella");
            lst.Add("Olivia");
            lst.Add("Ava");
            lst.Add("Lily");
            lst.Add("Chloe");
            lst.Add("Madison");
            lst.Add("Emily");
            lst.Add("Abigail");
            lst.Add("Addison");
            lst.Add("Mia");
            lst.Add("Madelyn");
            lst.Add("Ella");
            lst.Add("Hailey");
            lst.Add("Kaylee");
            lst.Add("Avery");
            lst.Add("Kaitlyn");
            lst.Add("Riley");
            lst.Add("Aubrey");
            lst.Add("Brooklyn");
            lst.Add("Peyton");
            lst.Add("Layla");
            lst.Add("Hannah");
            lst.Add("Charlotte");
            lst.Add("Bella");
            lst.Add("Natalie");
            lst.Add("Sarah");
            lst.Add("Grace");
            lst.Add("Amelia");
            lst.Add("Kylie");
            lst.Add("Arianna");
            lst.Add("Anna");
            lst.Add("Elizabeth");
            lst.Add("Sophie");
            lst.Add("Claire");
            lst.Add("Lila");
            lst.Add("Aaliyah");
            lst.Add("Gabriella");
            lst.Add("Elise");
            lst.Add("Lillian");
            lst.Add("Samantha");
            lst.Add("Makayla");
            lst.Add("Audrey");
            lst.Add("Alyssa");
            lst.Add("Ellie");
            lst.Add("Alexis");
            lst.Add("Isabelle");
            lst.Add("Savannah");
            lst.Add("Evelyn");
            lst.Add("Leah");
            lst.Add("Keira");
            lst.Add("Allison");
            lst.Add("Maya");
            lst.Add("Lucy");
            lst.Add("Sydney");
            lst.Add("Taylor");
            lst.Add("Molly");
            lst.Add("Lauren");
            lst.Add("Harper");
            lst.Add("Scarlett");
            lst.Add("Brianna");
            lst.Add("Victoria");
            lst.Add("Liliana");
            lst.Add("Aria");
            lst.Add("Kayla");
            lst.Add("Annabelle");
            lst.Add("Gianna");
            lst.Add("Kennedy");
            lst.Add("Stella");
            lst.Add("Reagan");
            lst.Add("Julia");
            lst.Add("Bailey");
            lst.Add("Alexandra");
            lst.Add("Jordyn");
            lst.Add("Nora");
            lst.Add("Carolin");
            lst.Add("Mackenzie");
            lst.Add("Jasmine");
            lst.Add("Jocelyn");
            lst.Add("Kendall");
            lst.Add("Morgan");
            lst.Add("Nevaeh");
            lst.Add("Maria");
            lst.Add("Eva");
            lst.Add("Juliana");
            lst.Add("Abby");
            lst.Add("Alexa");
            lst.Add("Summer");
            lst.Add("Brooke");
            lst.Add("Penelope");
            lst.Add("Violet");
            lst.Add("Kate");
            lst.Add("Hadley");
            lst.Add("Ashlyn");
            lst.Add("Sadie");
            lst.Add("Paige");
            lst.Add("Katherine");
            lst.Add("Sienna");
            lst.Add("Piper");
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
            // Specify connection options and open an connection
            NpgsqlConnection conn = new NpgsqlConnection("Server=172.16.8.20;User Id=POSMAN;" +
                                    "Password=apzon123;Database=Duc_Database;");
            conn.Open();

            // Close connection
            conn.Close();

            List<Employee> listEmployee = new List<Employee>();
            List<Employee> saveListEmployee = new List<Employee>();
            Console.WriteLine("Enter quantity of employees to save to Database: ");
            int numberSave = int.Parse(Console.ReadLine());

            conn.Open();
            for (int i = 0; i < numberSave; i++)
            {
                Random r = new Random();
                int id = i + 1;
                int randAge = r.Next(18, 30);
                string randName = GenRandomLastName();
                string randGender = GetRandomGender();

                listEmployee.Add(new Employee(id, randName, randAge, randGender));
                // Define a query
                var listStr = "INSERT INTO employees (name, age, gender) VALUES ('" + randName + "'," + randAge + ",'" + randGender + "')";
                //if(str == "")
                //{
                //    str = string.Concat(str, " " + listStr);
                //} else
                //{
                //    str = string.Concat(str, ",('" + randName + "', " + randAge + ", '" + randGender + "')");
                //}

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = listStr;
                    cmd.ExecuteNonQuery();
                }

                // Execute a query
            }

            string sql = "SELECT * FROM employees";
            var cmd1 = new NpgsqlCommand(sql, conn);

            NpgsqlDataReader rdr = cmd1.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", rdr[0], rdr[1],
                        rdr[2], rdr[3]);
            }
            conn.Close();

            listEmployee.ForEach((item) =>
            {
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
                Console.WriteLine("Enter 0 to stop program!");
                option = int.Parse(Console.ReadLine());
                if (option == 0)
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
                            saveListEmployee.Sort((em1, em2) =>
                            {
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
