using System;
using System.Collections.Generic;
using Npgsql;

namespace ListGenerateApp
{
    class Program
    {
        public static List<Employee> Compare()
        {
            List<Employee> lst = new List<Employee>();
            return lst;
        }

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

        public static string GenRandomFirstName(string gender)
        {
            List<string> maleFirstName = new List<string>();
            string str = string.Empty;
            maleFirstName.Add("Aiden");
            maleFirstName.Add("Jackson");
            maleFirstName.Add("Mason");
            maleFirstName.Add("Liam");
            maleFirstName.Add("Jacob");
            maleFirstName.Add("Jayden");
            maleFirstName.Add("Ethan");
            maleFirstName.Add("Noah");
            maleFirstName.Add("Lucas");
            maleFirstName.Add("Logan");
            maleFirstName.Add("Caleb");
            maleFirstName.Add("Caden");
            maleFirstName.Add("Jack");
            maleFirstName.Add("Ryan");
            maleFirstName.Add("Connor");
            maleFirstName.Add("Michael");
            maleFirstName.Add("Elijah");
            maleFirstName.Add("Brayden");
            maleFirstName.Add("Benjamin");
            maleFirstName.Add("Nicholas");
            maleFirstName.Add("Alexander");
            maleFirstName.Add("William");
            maleFirstName.Add("Matthew");
            maleFirstName.Add("James");
            maleFirstName.Add("Landon");
            maleFirstName.Add("Nathan");
            maleFirstName.Add("Dylan");
            maleFirstName.Add("Evan");
            maleFirstName.Add("Luke");
            maleFirstName.Add("Andrew");
            maleFirstName.Add("Gabriel");
            maleFirstName.Add("Gavin");
            maleFirstName.Add("Joshua");
            maleFirstName.Add("Owen");
            maleFirstName.Add("Daniel");
            maleFirstName.Add("Carter");
            maleFirstName.Add("Tyler");
            maleFirstName.Add("Cameron");
            maleFirstName.Add("Christian");
            maleFirstName.Add("Wyatt");
            maleFirstName.Add("Henry");
            maleFirstName.Add("Eli");
            maleFirstName.Add("Joseph");
            maleFirstName.Add("Max");
            maleFirstName.Add("Isaac");
            maleFirstName.Add("Samuel");
            maleFirstName.Add("Anthony");
            maleFirstName.Add("Grayson");
            maleFirstName.Add("Zachary");
            maleFirstName.Add("David");
            maleFirstName.Add("Christopher");
            maleFirstName.Add("John");
            maleFirstName.Add("Isaiah");
            maleFirstName.Add("Levi");
            maleFirstName.Add("Jonathan");
            maleFirstName.Add("Oliver");
            maleFirstName.Add("Chase");
            maleFirstName.Add("Cooper");
            maleFirstName.Add("Tristan");
            maleFirstName.Add("Colton");
            maleFirstName.Add("Austin");
            maleFirstName.Add("Colin");
            maleFirstName.Add("Charlie");
            maleFirstName.Add("Dominic");
            maleFirstName.Add("Parker");
            maleFirstName.Add("Hunter");
            maleFirstName.Add("Thomas");
            maleFirstName.Add("Alex");
            maleFirstName.Add("Ian");
            maleFirstName.Add("Jordan");
            maleFirstName.Add("Cole");
            maleFirstName.Add("Julian");
            maleFirstName.Add("Aaron");
            maleFirstName.Add("Carson");
            maleFirstName.Add("Miles");
            maleFirstName.Add("Blake");
            maleFirstName.Add("Brody");
            maleFirstName.Add("Adam");
            maleFirstName.Add("Sebastian");
            maleFirstName.Add("Adrian");
            maleFirstName.Add("Nolan");
            maleFirstName.Add("Sean");
            maleFirstName.Add("Riley");
            maleFirstName.Add("Bentley");
            maleFirstName.Add("Xavier");
            maleFirstName.Add("Hayden");
            maleFirstName.Add("Jeremiah");
            maleFirstName.Add("Jason");
            maleFirstName.Add("Jake");
            maleFirstName.Add("Asher");
            maleFirstName.Add("Micah");
            maleFirstName.Add("Jace");
            maleFirstName.Add("Brandon");
            maleFirstName.Add("Josiah");
            maleFirstName.Add("Hudson");
            maleFirstName.Add("Nathaniel");
            maleFirstName.Add("Bryson");
            maleFirstName.Add("Ryder");
            maleFirstName.Add("Justin");
            maleFirstName.Add("Bryce");

            //—————female
            List<string> femaleFirstName = new List<string>();
            femaleFirstName.Add("Sophia");
            femaleFirstName.Add("Emma");
            femaleFirstName.Add("Isabella");
            femaleFirstName.Add("Olivia");
            femaleFirstName.Add("Ava");
            femaleFirstName.Add("Lily");
            femaleFirstName.Add("Chloe");
            femaleFirstName.Add("Madison");
            femaleFirstName.Add("Emily");
            femaleFirstName.Add("Abigail");
            femaleFirstName.Add("Addison");
            femaleFirstName.Add("Mia");
            femaleFirstName.Add("Madelyn");
            femaleFirstName.Add("Ella");
            femaleFirstName.Add("Hailey");
            femaleFirstName.Add("Kaylee");
            femaleFirstName.Add("Avery");
            femaleFirstName.Add("Kaitlyn");
            femaleFirstName.Add("Riley");
            femaleFirstName.Add("Aubrey");
            femaleFirstName.Add("Brooklyn");
            femaleFirstName.Add("Peyton");
            femaleFirstName.Add("Layla");
            femaleFirstName.Add("Hannah");
            femaleFirstName.Add("Charlotte");
            femaleFirstName.Add("Bella");
            femaleFirstName.Add("Natalie");
            femaleFirstName.Add("Sarah");
            femaleFirstName.Add("Grace");
            femaleFirstName.Add("Amelia");
            femaleFirstName.Add("Kylie");
            femaleFirstName.Add("Arianna");
            femaleFirstName.Add("Anna");
            femaleFirstName.Add("Elizabeth");
            femaleFirstName.Add("Sophie");
            femaleFirstName.Add("Claire");
            femaleFirstName.Add("Lila");
            femaleFirstName.Add("Aaliyah");
            femaleFirstName.Add("Gabriella");
            femaleFirstName.Add("Elise");
            femaleFirstName.Add("Lillian");
            femaleFirstName.Add("Samantha");
            femaleFirstName.Add("Makayla");
            femaleFirstName.Add("Audrey");
            femaleFirstName.Add("Alyssa");
            femaleFirstName.Add("Ellie");
            femaleFirstName.Add("Alexis");
            femaleFirstName.Add("Isabelle");
            femaleFirstName.Add("Savannah");
            femaleFirstName.Add("Evelyn");
            femaleFirstName.Add("Leah");
            femaleFirstName.Add("Keira");
            femaleFirstName.Add("Allison");
            femaleFirstName.Add("Maya");
            femaleFirstName.Add("Lucy");
            femaleFirstName.Add("Sydney");
            femaleFirstName.Add("Taylor");
            femaleFirstName.Add("Molly");
            femaleFirstName.Add("Lauren");
            femaleFirstName.Add("Harper");
            femaleFirstName.Add("Scarlett");
            femaleFirstName.Add("Brianna");
            femaleFirstName.Add("Victoria");
            femaleFirstName.Add("Liliana");
            femaleFirstName.Add("Aria");
            femaleFirstName.Add("Kayla");
            femaleFirstName.Add("Annabelle");
            femaleFirstName.Add("Gianna");
            femaleFirstName.Add("Kennedy");
            femaleFirstName.Add("Stella");
            femaleFirstName.Add("Reagan");
            femaleFirstName.Add("Julia");
            femaleFirstName.Add("Bailey");
            femaleFirstName.Add("Alexandra");
            femaleFirstName.Add("Jordyn");
            femaleFirstName.Add("Nora");
            femaleFirstName.Add("Carolin");
            femaleFirstName.Add("Mackenzie");
            femaleFirstName.Add("Jasmine");
            femaleFirstName.Add("Jocelyn");
            femaleFirstName.Add("Kendall");
            femaleFirstName.Add("Morgan");
            femaleFirstName.Add("Nevaeh");
            femaleFirstName.Add("Maria");
            femaleFirstName.Add("Eva");
            femaleFirstName.Add("Juliana");
            femaleFirstName.Add("Abby");
            femaleFirstName.Add("Alexa");
            femaleFirstName.Add("Summer");
            femaleFirstName.Add("Brooke");
            femaleFirstName.Add("Penelope");
            femaleFirstName.Add("Violet");
            femaleFirstName.Add("Kate");
            femaleFirstName.Add("Hadley");
            femaleFirstName.Add("Ashlyn");
            femaleFirstName.Add("Sadie");
            femaleFirstName.Add("Paige");
            femaleFirstName.Add("Katherine");
            femaleFirstName.Add("Sienna");
            femaleFirstName.Add("Piper");
            Random rnd = new Random();
            if (gender == "Male")
            {
                return maleFirstName[rnd.Next(0, maleFirstName.Count)];
            }
            else
            {
                return femaleFirstName[rnd.Next(0, femaleFirstName.Count)];
            }
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
            List<Employee> dbListEmployee = new List<Employee>();
            // Specify connection options and open an connection
            NpgsqlConnection conn = new NpgsqlConnection("Server=172.16.8.20;User Id=POSMAN;" +
                                    "Password=apzon123;Database=Duc_Database;");
            conn.Open();

            Console.WriteLine("Checking Database...");

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM employees", conn);

            // Execute the query and obtain a result set
            NpgsqlDataReader dr = command.ExecuteReader();

            // Output rows
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["id"]);
                string name = dr["name"].ToString();
                int age = Convert.ToInt32(dr["age"]);
                string gender = dr["gender"].ToString();
                string fatherId = dr["fatherId"].ToString() != null ? dr["fatherId"].ToString() : null;
                dbListEmployee.Add(new Employee() { UId = id, Name = name, Age = age, FatherId = fatherId, Gender = gender });
            }

            dr.Close();

            if (dbListEmployee.Count >= 0 && dbListEmployee.Count < 1000)
            {
                //Genarate 1000 Employees in Database
                for (int i = 0; i < 1000; i++)
                {
                    Random r = new Random();
                    int id = i + 1;
                    int randAge = r.Next(18, 30);
                    string randGender = GetRandomGender();
                    string randName = GenRandomFirstName(randGender) + " " + GenRandomLastName();

                    //listEmployee.Add(new Employee(id, randName, randAge, randGender));
                    // Define a query
                    var listStr = "INSERT INTO employees (name, age, gender) VALUES ('" + randName + "'," + randAge + ",'" + randGender + "')";

                    // Execute a query
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = listStr;
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            List<Employee> listEmployee = new List<Employee>();
            List<Employee> saveListEmployee = new List<Employee>();

            dbListEmployee.Clear();

            string sql = "SELECT * FROM employees";
            var cmd1 = new NpgsqlCommand(sql, conn);

            NpgsqlDataReader rdr = cmd1.ExecuteReader();
            Console.WriteLine("Loading data from database");

            while (rdr.Read())
            {
                int id = Convert.ToInt32(rdr["id"]);
                string name = rdr["name"].ToString();
                int age = Convert.ToInt32(rdr["age"]);
                string gender = rdr["gender"].ToString();
                string fatherId = rdr["fatherId"].ToString();
                dbListEmployee.Add(new Employee() { UId = id, Name = name, Age = age, FatherId = fatherId, Gender = gender });
            }

            rdr.Close();

            foreach (var employee in dbListEmployee)
            {
                Console.WriteLine(employee.UId + " " + employee.Name + " " + employee.Age + " " + employee.Gender + " " + employee.FatherId);
            }


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
                Console.WriteLine("6 - Add new employees");
                Console.WriteLine("7 - Find family tree");
                Console.WriteLine("Enter 0 to save and end program!");
                option = int.Parse(Console.ReadLine());
                if (option == 0)
                {
                    Console.WriteLine("Saving...!");
                    foreach (var em in dbListEmployee)
                    {
                        // Define a query
                        var listStr = "UPDATE employees SET name = '" + em.Name + "', age = '" + em.Age + "', gender = '" + em.Gender + "' WHERE id =" + em.UId;

                        // Execute a query
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = listStr;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    conn.Close();
                    System.Environment.Exit(1);
                }
                else
                {
                    switch (option)
                    {
                        case (1):
                            Console.WriteLine("Enter keyword");
                            string keyword = Console.ReadLine().ToLower();
                            List<Employee> filterList = new List<Employee>();
                            for (int i = 0; i < dbListEmployee.Count; i++)
                            {
                                if (dbListEmployee[i].Name.ToLower().IndexOf(keyword) != -1)
                                {
                                    Console.WriteLine(dbListEmployee[i].Name);
                                    filterList.Add(new Employee() { UId = dbListEmployee[i].UId, Name = dbListEmployee[i].Name, Age = dbListEmployee[i].Age, FatherId = dbListEmployee[i].FatherId, Gender = dbListEmployee[i].Gender });
                                }
                            }
                            if (filterList.Count > 0)
                                foreach (var employee in filterList)
                                {
                                    Console.WriteLine(employee.UId + " " + employee.Name + " " + employee.Age + " " + employee.Gender);
                                }
                            else
                            {
                                Console.WriteLine("No Result Found!");
                            }
                            break;
                        case (2):
                            for (int i = 0; i < dbListEmployee.Count; i++) //Compare Name method
                            {
                                for (int j = 0; j < dbListEmployee.Count - 1; j++)
                                {
                                    if (dbListEmployee[j].Name.CompareTo(dbListEmployee[j + 1].Name) > 0)
                                    {
                                        var temp = dbListEmployee[j];
                                        dbListEmployee[j] = dbListEmployee[j + 1];
                                        dbListEmployee[j + 1] = temp;
                                    }
                                }
                            }
                            dbListEmployee.ForEach((item) =>
                            {
                                Console.WriteLine(item.UId + " " + item.Name + " " + item.Age + " " + item.Gender);
                            });
                            break;
                        case (3):
                            for (int i = 0; i < dbListEmployee.Count; i++) //Compare Age method 
                            {
                                for (int j = 0; j < dbListEmployee.Count - 1; j++)
                                {
                                    if (dbListEmployee[j].Age.CompareTo(dbListEmployee[j + 1].Age) > 0)
                                    {
                                        var temp = dbListEmployee[j];
                                        dbListEmployee[j] = dbListEmployee[j + 1];
                                        dbListEmployee[j + 1] = temp;
                                    }
                                }
                            }
                            dbListEmployee.ForEach((item) =>
                            {
                                Console.WriteLine(item.UId + " " + item.Name + " " + item.Age + " " + item.Gender + " " + item.FatherId);
                            });
                            break;
                        case (4):
                            List<Employee> filterMaleList = new List<Employee>();
                            for (int i = 0; i < dbListEmployee.Count; i++)
                            {
                                if (dbListEmployee[i].Gender == "Male")
                                {
                                    filterMaleList.Add(new Employee() { UId = dbListEmployee[i].UId, Name = dbListEmployee[i].Name, Age = dbListEmployee[i].Age, Gender = dbListEmployee[i].Gender, FatherId = dbListEmployee[i].FatherId });
                                }
                            }
                            filterMaleList.ForEach((item) =>
                            {
                                Console.WriteLine(item.UId + " " + item.Name + " " + item.Age + " " + item.Gender + " " + item.FatherId);
                            });
                            break;
                        case (5):
                            List<Employee> filterFemaleList = new List<Employee>();
                            for (int i = 0; i < dbListEmployee.Count; i++)
                            {
                                if (dbListEmployee[i].Gender == "Female")
                                {
                                    filterFemaleList.Add(new Employee() { UId = dbListEmployee[i].UId, Name = dbListEmployee[i].Name, Age = dbListEmployee[i].Age, Gender = dbListEmployee[i].Gender, FatherId = dbListEmployee[i].FatherId });
                                }
                            }
                            filterFemaleList.ForEach((item) =>
                            {
                                Console.WriteLine(item.UId + " " + item.Name + " " + item.Age + " " + item.Gender + " " + item.FatherId);
                            });
                            break;
                        case (6):
                            Console.WriteLine("Enter quantity of employees to save to Database: ");
                            int numberSave = int.Parse(Console.ReadLine());

                            for (int i = 0; i < numberSave; i++)
                            {
                                Random r = new Random();
                                int id = i + 1;
                                int randAge = r.Next(18, 30);
                                string randName = GenRandomLastName();
                                string randGender = GetRandomGender();

                                // Define a query
                                var listStr = "INSERT INTO employees (name, age, gender) VALUES ('" + randName + "'," + randAge + ",'" + randGender + "')";

                                // Execute a query
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;
                                    cmd.CommandText = listStr;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            dbListEmployee.Clear();

                            NpgsqlDataReader dr1 = cmd1.ExecuteReader();

                            while (dr1.Read())
                            {
                                int id = Convert.ToInt32(dr1["id"]);
                                string name = dr1["name"].ToString();
                                int age = Convert.ToInt32(dr1["age"]);
                                string gender = dr1["gender"].ToString();
                                string fatherId = dr1["fatherId"].ToString();
                                dbListEmployee.Add(new Employee() { UId = id, Name = name, Age = age, FatherId = fatherId, Gender = gender });
                            }

                            Console.WriteLine("Update database");
                            foreach (var employee in dbListEmployee)
                            {
                                Console.WriteLine(employee.UId + " " + employee.Name + " " + employee.Age + " " + employee.Gender);
                            }

                            dr1.Close();

                            break;
                        case (7):
                            var familyLastName = Console.ReadLine();
                            Console.WriteLine(familyLastName);
                            break;
                        default:
                            break;
                    }
                }
            } while (option < 8);
        }
    }
}
