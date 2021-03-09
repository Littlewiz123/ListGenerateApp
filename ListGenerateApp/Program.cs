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


        static string GetRandomDepartment()
        {
            string[] departments = new string[] { "Accountant", "Business", "Makerting", "Administrative", "Information technology" };
            Random rand = new Random();
            int index = rand.Next(departments.Length);
            string department = departments[index];
            return department;
        }
        static void Main(string[] args)
        {
            Company company = new Company();
            Genealogy peopleLst = new Genealogy();
            List<Employee> dbListEmployee = new List<Employee>();
            List<Employee> elderEmployee = new List<Employee>();
            List<Employee> youngEmployee = new List<Employee>();
            List<Person> dbList = new List<Person>();
            // Specify connection options and open an connection
            NpgsqlConnection conn = new NpgsqlConnection("Server=172.16.8.20;User Id=POSMAN;" +
                                    "Password=apzon123;Database=Duc_Database;");
            //NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres; " +
            // "Password=123456;Database=Learn_.Net;");
            conn.Open();

            Console.WriteLine("Checking Database...");

            NpgsqlCommand command = new NpgsqlCommand("SELECT users.*, employees.department FROM users INNER JOIN employees ON users.eid = employees.id", conn);

            // Execute the query and obtain a result set
            NpgsqlDataReader dr = command.ExecuteReader();

            // Output rows
            while (dr.Read())
            {
                //int id = Convert.ToInt32(dr["id"]);
                string name = dr["name"].ToString();
                int age = Convert.ToInt32(dr["age"]);
                string gender = dr["gender"].ToString();
                string birthday = dr["birthday"].ToString();
                string department = dr["department"].ToString();
                DateTime date = Convert.ToDateTime(birthday);
                List<Person> children = new List<Person>();
                List<Person> parent = new List<Person>();
                //string birthday = dr["birthday"];
                dbListEmployee.Add(new Employee() { Name = name, Age = age, Birthbay = date, Gender = gender, Children = children, Department = department });
            }

            dr.Close();

            if (dbListEmployee.Count >= 0 && dbListEmployee.Count < 1000)
            {
                //genarate 1000 employees in database
                for (int i = 0; i < 1000; i++)
                {
                    Random r = new Random();
                    int randDay = r.Next(1, 28);
                    int randMonth = r.Next(1, 12);
                    int randYear = r.Next(1961, 2003);
                    string date = randYear + "-" + randMonth + "-" + randDay;
                    int age = 2021 - randYear;
                    string randgender = GetRandomGender();
                    string randname = GenRandomFirstName(randgender) + " " + GenRandomLastName();
                    int eid = i + 1;
                    //Save data to Users table
                    // define a query
                    var liststr = "insert into users (name, age, gender, birthday, eid) values ('" + randname + "'," + age + ",'" + randgender + "','" + date + "', " + eid + ")";

                    //// execute a query
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = liststr;
                        cmd.ExecuteNonQuery();
                    }

                    //Save data to Employees table
                    var department = GetRandomDepartment();
                    int randUid = r.Next(1, 1000);
                    int uid = i + 1;
                    //define a query
                    var emSql = "insert into employees (uid, department) values (" + uid + ",'" + department + "')";

                    //// execute a query
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = emSql;
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            dbListEmployee.Clear();

            NpgsqlCommand sqlCmd = new NpgsqlCommand("SELECT users.*, employees.department FROM users INNER JOIN employees ON users.eid = employees.id", conn);

            // Execute the query and obtain a result set
            NpgsqlDataReader dr1 = sqlCmd.ExecuteReader();

            // Output rows
            while (dr.Read())
            {
                //int id = Convert.ToInt32(dr["id"]);
                string name = dr1["name"].ToString();
                int age = Convert.ToInt32(dr1["age"]);
                string gender = dr1["gender"].ToString();
                string birthday = dr1["birthday"].ToString();
                string department = dr1["department"].ToString();
                int eid = Convert.ToInt32(dr1["eid"]);
                DateTime date = Convert.ToDateTime(birthday);
                List<Person> children = new List<Person>();
                List<Person> parent = new List<Person>();
                //string birthday = dr["birthday"];
                dbList.Add(new Employee() { Name = name, Age = age, Birthbay = date, Gender = gender, Children = children, Department = department, eid = eid, Parent = parent });
                company.People = dbList;
                peopleLst.People = dbList;
            }

            dr.Close();

            Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", "Name", "Age", "Gender", "Birthday", "eId", "Department");
            company.People.ForEach((item) =>
            {
                if (item.GetType() == typeof(Employee))
                {
                    var emId = ((Employee)item).eid;
                    var department = ((Employee)item).Department;
                    Console.WriteLine("{0,-20} {1, 10} {2, 15} {3,15} {4, 20} {5, 20}", item.Name, item.Age, item.Gender, item.Birthbay.ToString().Substring(0, 10), emId, department);
                }
            });

            List<string> everyLastName = new List<string>();
            for (var i = 0; i < dbList.Count; i++)
            {
                if (dbList[i].Age < 45)
                {
                    var name = dbList[i].Name.Split(" ");
                    everyLastName.Add(name[1]);
                    //Random random = new Random();
                    //int start2 = random.Next(0, findedParent.Count - 1);
                    //dbListEmployee[i].FatherId = findedParent[start2].UId.ToString();
                }
            }

            List<string> distinctLastName = new List<string>();
            if (everyLastName.Count > 0)
            {
                for (int n = 0; n < everyLastName.Count; n++)
                {

                    if (distinctLastName.Count == 0)
                    {
                        distinctLastName.Add(everyLastName[n].Trim());
                    }
                    else
                    {
                        bool check = false;
                        for (int j = 0; j < distinctLastName.Count; j++)
                        {
                            if (everyLastName[n] == distinctLastName[j])
                            {
                                check = true;
                            }
                        }
                        if (check == false)
                        {
                            distinctLastName.Add(everyLastName[n]);
                        }
                    }
                }
            }

            //Get random child and parent
            for (int a = 0; a < distinctLastName.Count; a++)
            {
                List<Person> sameLastNameLst = new List<Person>();
                for (int b = 0; b < peopleLst.People.Count; b++)
                {
                    var name = peopleLst.People[b].Name.Split(" ");
                    if (name[1] == distinctLastName[a])
                    {
                        sameLastNameLst.Add(new Person() { Name = peopleLst.People[b].Name, Age = peopleLst.People[b].Age, Birthbay = peopleLst.People[b].Birthbay, Gender = peopleLst.People[b].Gender });
                    }
                }
                List<Person> children = new List<Person>();
                List<Person> youngPeople = new List<Person>();
                List<Person> oldPeople = new List<Person>();
                //sameLastNameLst.ForEach((item) =>
                //{
                //    Console.WriteLine(item.Name + " " + item.Age);
                //});
                for (int c = 0; c < sameLastNameLst.Count; c++)
                {
                    if (sameLastNameLst[c].Age >= 45)
                    {
                        oldPeople.Add(new Person() { Name = sameLastNameLst[c].Name, Age = sameLastNameLst[c].Age, Birthbay = sameLastNameLst[c].Birthbay, Gender = sameLastNameLst[c].Gender });
                    }
                    else if (sameLastNameLst[c].Age <= 30)
                    {
                        youngPeople.Add(new Person() { Name = sameLastNameLst[c].Name, Age = sameLastNameLst[c].Age, Birthbay = sameLastNameLst[c].Birthbay, Gender = sameLastNameLst[c].Gender });
                    }
                }

                if (oldPeople.Count > 0 && youngPeople.Count > 0)
                {
                    for (int d = 0; d < oldPeople.Count; d++)
                    {
                        Random r = new Random();
                        int randChildIndex = r.Next(0, youngPeople.Count);
                        List<Person> Child = new List<Person>();
                        Child.Add(new Person() { Name = youngPeople[randChildIndex].Name, Age = youngPeople[randChildIndex].Age, Birthbay = youngPeople[randChildIndex].Birthbay, Gender = youngPeople[randChildIndex].Gender });
                        //youngPeople[d].Children = Child;
                        oldPeople[d].Children = Child;
                    }

                    for (int e = 0; e < oldPeople.Count; e++)
                    {
                        for (int f = 0; f < peopleLst.People.Count; f++)
                        {
                            if (peopleLst.People[f].Name.ToLower() == oldPeople[e].Name.ToLower())
                            {
                                peopleLst.People[f] = oldPeople[e];
                            }
                        }
                    }
                }
            }

            //everyLastName.ForEach((item) => {
            //    Console.WriteLine(item);
            //});

            //Console.WriteLine();

            //distinctLastName.ForEach((item) => {
            //    Console.WriteLine(item);
            //});

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
                Console.WriteLine("7 - Family tree");
                Console.WriteLine("Enter 0 to save and end program!");
                option = int.Parse(Console.ReadLine());
                if (option == 0)
                {
                    Console.WriteLine("Saving...!");
                    for (int i = 1; i < dbList.Count; i++)
                    {
                        //Update users Table
                        var day = dbList[i].Birthbay.Day;
                        var month = dbList[i].Birthbay.Month;
                        var year = dbList[i].Birthbay.Year;
                        string date = year + "-" + month + "-" + day;
                        // Define a query
                        var listStr = "UPDATE users SET name = '" + dbList[i].Name + "', age = '" + dbList[i].Age + "', gender = '" + dbList[i].Gender + "', birthday = '" + date + "' WHERE id =" + i;

                        // Execute a query
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = listStr;
                            cmd.ExecuteNonQuery();
                        }

                        //Update employees Table
                        // Define a query
                        if (dbList[i].GetType() == typeof(Employee))
                        {
                            var department = ((Employee)dbList[i]).Department;
                            var newStr = "UPDATE employees SET department = '" + department + "' WHERE id =" + i;

                            // Execute a query
                            using (var cmd = new NpgsqlCommand())
                            {
                                cmd.Connection = conn;
                                cmd.CommandText = newStr;
                                cmd.ExecuteNonQuery();
                            }
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
                            Console.WriteLine("Write Keyword");
                            var searchStr = Console.ReadLine();
                            Console.WriteLine("Search Result");
                            company.SearchForPerson(searchStr);
                            break;
                        case (2):
                            company.OrderByName();
                            break;
                        case (3):
                            company.OrderByAge();
                            break;
                        case (4):
                            company.filterMale();
                            break;
                        case (5):
                            company.filterFemale();
                            break;
                        case (6):
                            Console.WriteLine("Enter quantity of employees to save to Database: ");
                            int numberSave = int.Parse(Console.ReadLine());

                            for (int i = 0; i < numberSave; i++)
                            {
                                Random r = new Random();
                                int randDay = r.Next(1, 28);
                                int randMonth = r.Next(1, 12);
                                int randYear = r.Next(1961, 2003);
                                string date = randYear + "-" + randMonth + "-" + randDay;
                                int age = 2021 - randYear;
                                string randgender = GetRandomGender();
                                string randname = GenRandomFirstName(randgender) + " " + GenRandomLastName();
                                int eid = dbList.Count + numberSave;
                                //Save data to Users table
                                // define a query
                                var liststr = "insert into users (name, age, gender, birthday, eid) values ('" + randname + "'," + age + ",'" + randgender + "','" + date + "', " + eid + ")";

                                //// execute a query
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;
                                    cmd.CommandText = liststr;
                                    cmd.ExecuteNonQuery();
                                }

                                //Save data to Employees table
                                var department = GetRandomDepartment();
                                int randUid = r.Next(1, 1000);
                                int uid = dbList.Count + numberSave;
                                //define a query
                                var emSql = "insert into employees (uid, department) values (" + uid + ",'" + department + "')";

                                //// execute a query
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;
                                    cmd.CommandText = emSql;
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            break;
                        case (7):
                            var list = peopleLst.People;
                            for (int e = 0; e < list.Count; e++)
                            {
                                if (list[e].Children.Count > 0 && list[e].Children != null)
                                {
                                    Console.WriteLine("{0,-20} {1,10}", list[e].Name, list[e].Children.Count);
                                }
                            }
                            //Vẽ cây gia đình theo tên
                            Console.WriteLine("Write Person Name");
                            string name = Console.ReadLine();
                            for (int e = 0; e < peopleLst.People.Count; e++)
                            {
                                if (peopleLst.People[e].Name.TrimEnd().ToLower() == name.ToLower())
                                {
                                    peopleLst.DrawFamilyTree(peopleLst.People[e]);
                                }
                            }

                            //{
                            //    Console.WriteLine(item.Name + " " + item.Children + " " + item.Parent);
                            //});
                            break;
                        default:
                            break;
                    }
                }
            } while (option < 8);
        }
    }
}
