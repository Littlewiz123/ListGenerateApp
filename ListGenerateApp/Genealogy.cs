using System;
using System.Collections.Generic;
using System.Text;

namespace ListGenerateApp
{
    class Genealogy : Population
    {
        public void DrawFamilyTree(Person person)
        {
            //var parent = person.Parent;
            var father = person.Father;
            if (father != null)
            {
                //Tìm bố mẹ của bố mẹ -> In
                //FindGrandparent(father);
                if(FindFather(father))
                {
                    Console.WriteLine();
                    Console.WriteLine("--- Father of " + person.Name + ":");
                    Console.WriteLine("--- {0, -20} | {1, 15} | {2,15} | {3, 10}", "Name", "Age", "Gender", "Birthday");
                    Console.WriteLine("--- {0, -20} | {1, 15} | {2,15} | {3, 10}", father.Name, father.Age, father.Gender, father.Birthbay.ToString().Substring(0, 10));
                    Console.WriteLine("----- Person:");
                    Console.WriteLine("----- {0, -20} | {1, 15} | {2,15} | {3, 10}", person.Name, person.Age, person.Gender, person.Birthbay.ToString().Substring(0, 10));
                } else
                {
                    Console.WriteLine();
                    Console.WriteLine("Father of " + person.Name + ":");
                    Console.WriteLine("{0, -20} | {1, 15} | {2,15} | {3, 10}", "Name", "Age", "Gender", "Birthday");
                    Console.WriteLine("{0, -20} | {1, 15} | {2,15} | {3, 10}", father.Name, father.Age, father.Gender, father.Birthbay.ToString().Substring(0, 10));
                    Console.WriteLine("--- Person:");
                    Console.WriteLine("--- {0, -20} | {1, 15} | {2,15} | {3, 10}", person.Name, person.Age, person.Gender, person.Birthbay.ToString().Substring(0, 10));
                } 
            }
            
        }

        public bool FindFather(Person person)
        {
            var father = person.Father;
            if (father != null)
            {
                if (FindFather(father))
                {
                    Console.WriteLine();
                    Console.WriteLine("--- Father of " + person.Name + ":");
                    Console.WriteLine("--- {0, -20} | {1, 15} | {2,15} | {3, 10}", "Name", "Age", "Gender", "Birthday");
                    Console.WriteLine("--- {0, -20} | {1, 15} | {2,15} | {3, 10}", father.Name, father.Age, father.Gender, father.Birthbay.ToString().Substring(0, 10));
                    Console.WriteLine("----- Person:");
                    Console.WriteLine("----- {0, -20} | {1, 15} | {2,15} | {3, 10}", person.Name, person.Age, person.Gender, person.Birthbay.ToString().Substring(0, 10));
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Father of " + person.Name + ":");
                    Console.WriteLine("{0, -20} | {1, 15} | {2,15} | {3, 10}", "Name", "Age", "Gender", "Birthday");
                    Console.WriteLine("{0, -20} | {1, 15} | {2,15} | {3, 10}", father.Name, father.Age, father.Gender, father.Birthbay.ToString().Substring(0, 10));
                    Console.WriteLine("--- Person:");
                    Console.WriteLine("--- {0, -20} | {1, 15} | {2,15} | {3, 10}", person.Name, person.Age, person.Gender, person.Birthbay.ToString().Substring(0, 10));
                }
                return true;
            }
            return false;
        }
    }
}
