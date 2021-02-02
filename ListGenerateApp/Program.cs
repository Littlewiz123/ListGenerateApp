using System;
using System.Collections.Generic;
using System.Linq;
//using Npgsql;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

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
            str = lst.OrderBy(xx => rnd.Next()).First();
            return str;
        }

        static string GetRandomGender()
        {
            string[] genders = new string[] { "Male", "Female" };
            Random rand = new Random();
            int index = rand.Next(genders.Count());
            string gender = genders[index];
            return gender;
        }

        static void Main(string[] args)
        {
            Employee abc = new Employee("1000", "Đức", 24, "Male");
            foreach(PropertyInfo property in abc.GetType().GetProperties())
            {
                string property_name = property.Name;
                object property_value = property.GetValue(abc);
                Console.WriteLine($"Thuộc tính {property_name} giá trị là {property_value}");
            }

            Employee ng1 = new Employee(new BigYell());
            ng1.Yell();

            // Tạo và cấu hình ServiceCollection
            var services = new ServiceCollection();
            services.AddSingleton<A>(); // Đăng ký dịch vụ A,  kiểu singleton (một bản đơn nhất)
            services.AddTransient<B>(); // Đăng ký dịch vụ B, kiểu transient (tạo mới mỗi khi yêu cầu)
            services.AddScoped<C>();    // Đăng ký dịch vụ C, kiểu scoped (tạo mới trong một phạm vi)

            var serviceprovider = services.BuildServiceProvider(); // Tạo serviceprovider

            // SỬ DỤNG


            // Yêu cầu dịch vụ B, DI tự động tạo A và Inject vào B khi B khởi tạo
            Console.WriteLine("Yêu cầu lấy dịch B lần đầu, lưu vào b1:");
            B b1 = serviceprovider.GetService<B>();
            // Output:
            //    A created
            //    B created

            // Yêu cầu lại dịch vụ B: B đăng ký là transient (tạm), nên đối tượng thực sự tạo lại
            // Dịch vụ A do là singleton, nên nó không tạo lại (có sẵn trong ServiceCollection đã tạo lần trước)
            // nó sẽ Inject vào dịch vụ B mới
            Console.WriteLine("Yêu cầu lấy dịch B lần hai, lưu vào b2:");
            B b2 = serviceprovider.GetService<B>();
            // Output:
            //    B created

            // b1 và b2 là hai đối tượng khác nhau
            Console.WriteLine("Thông tin về b1 và b2:");
            b1.ShowInfo();
            b2.ShowInfo();


            // Yêu  cầu  A, A (singleton) đã tạo nên nó trả về đối dịch vụ
            // đã từng tạo khi tạo B (Inject vào B)
            Console.WriteLine("Yêu cầu lấy dịch A, lưu vào a:");
            A a = serviceprovider.GetService<A>();
            //Console.WriteLine("Thông tin về a:");
            //a.ShowInfo();

            // Yêu cầu dịch vụ C, C là loại scoped (1 phiên bản trong một phạm vi, scoped)
            Console.WriteLine("Yêu cầu lấy dịch C, lưu vào c1:");
            C c1 = serviceprovider.GetService<C>();
            // Out: C created

            // Yêu cầu C, C không tạo mới vì scoped không đổi, nó chính là c1
            Console.WriteLine("Yêu cầu lấy dịch C lần 2, lưu vào c2:");
            C c2 = serviceprovider.GetService<C>();

            Console.WriteLine("Thông tin về c1 và c2:");
            c1.ShowInfo();
            c2.ShowInfo();

            // Tạo scope mới
            Console.WriteLine("-----------New scope---------");
            using (var scope = serviceprovider.CreateScope())
            {
                // Yêu  cầu  A, A đã tạo nên nó trả về đối dịch vụ mà đã Inject vào B, cho dù là scope mới
                a = scope.ServiceProvider.GetService<A>();
                // Yêu cầu C, C tạo mới vì scope mới (C kiểu scoped)
                C c = scope.ServiceProvider.GetService<C>();
            }

            Console.WriteLine(GetRandomGender());
            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < 1000; i++)
            {
                Random r = new Random();
                string id = i.ToString();
                int randAge = r.Next(18, 30);
                string randName = GenRandomLastName();
                string randGender = GetRandomGender();
                
                listEmployee.Add(new Employee(id, randName, randAge, randGender));
            }
            List<Employee> saveListEmployee = new List<Employee>();
            listEmployee.ForEach((item) => {
                saveListEmployee.Add(item);
            });

            //var testLinq = from employee in listEmployee select employee;
            //foreach(var em in testLinq)
            //{
            //    Console.WriteLine(em.Id + " " + em.Name + " " + em.Age + " " + em.Gender);
            //}

            Console.WriteLine("Select Options");
            Console.WriteLine("1 - Search by Name");
            Console.WriteLine("2 - Order list by User Name");
            Console.WriteLine("3 - Order list by Age");
            Console.WriteLine("4 - Filter list only Male");
            Console.WriteLine("5 - Filter list only Female");
            string option = Console.ReadLine();
            if(option != null)
            {
                switch (option)
                {
                    case ("1"):
                        Console.WriteLine("Enter keyword");
                        string text = Console.ReadLine().ToLower();
                        List<Employee> filterList = saveListEmployee.FindAll(employee => employee.Name.ToLower().IndexOf(text.ToLower()) != -1);
                        if (filterList.Count > 0)
                            foreach (var employee in filterList)
                            {
                                Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Age + " " + employee.Gender);
                            }
                        break;
                    case ("2"):
                        var sortListByName = saveListEmployee.OrderBy(x => x.Name).ToList();
                        foreach (var employee in sortListByName)
                        {
                            Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Age + " " + employee.Gender);
                        }
                        break;
                    case ("3"):
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
                    case ("4"):
                        List<Employee> filterMaleList = saveListEmployee.FindAll(employee => employee.Gender.ToLower() == "Male".ToLower());
                        foreach (var employee in filterMaleList)
                        {
                            Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Age + " " + employee.Gender);
                        }
                        break;
                    case ("5"):
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
        }
    }
}
