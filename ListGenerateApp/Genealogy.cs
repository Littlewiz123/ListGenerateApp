using System;
using System.Collections.Generic;
using System.Text;

namespace ListGenerateApp
{
    class Genealogy : Population
    {
        public void DrawFamilyTree(Person person)
        {
            var parent = person.Parent;
            var children = person.Children;
            if (parent.Count > 0)
            {
                //Tìm bố mẹ của bố mẹ -> In
                for (int i = 0; i < parent.Count; i++)
                {
                    FindGrandparent(parent[i]);
                }
                Console.WriteLine("Parent of" + person.Name + ":");
                Console.WriteLine("{0, -20} | {1, 15} | {2,15} | {3, 10}", "Name", "Age", "Gender", "Birthday");
                for (int i = 0; i < parent.Count; i++)
                {
                    Console.WriteLine("{0, -20} | {1, 15} | {2,15} | {3, 10}", parent[i].Name, parent[i].Age, parent[i].Gender, parent[i].Birthbay);
                }
            }
            Console.WriteLine("----- Current Person:");
            Console.WriteLine("----- {0, -20} | {1, 15} | {2,15} | {3, 10}", person.Name, person.Age, person.Gender, person.Birthbay);
            if (children.Count > 0)
            {
                //Tìm con của con -> In
                for (int i = 0; i < children.Count; i++)
                {
                    FindGrandchild(children[i]);
                }
                Console.WriteLine("----- ------ Children of" + person.Name + ":");
                Console.WriteLine("----- ------ {0, -20} | {1, 15} | {2,15} | {3, 10}", "Name", "Age", "Gender", "Birthday");
                for (int i = 0; i < children.Count; i++)
                {
                    Console.WriteLine("----- ------ {0, -20} | {1, 15} | {2,15} | {3, 10}", children[i].Name, children[i].Age, children[i].Gender, children[i].Birthbay);
                }
            }
        }

        public void FindGrandparent(Person person)
        {
            var parent = person.Parent;
            if (parent.Count > 0)
            {
                Console.WriteLine("Grandparent of " + person.Name + ":");
                for (int i = 0; i < parent.Count; i++)
                {
                    Console.WriteLine("{0, -20} | {1, 15} | {2,15} | {3, 10}", parent[i].Name, parent[i].Age, parent[i].Gender, parent[i].Birthbay);
                }
            }
        }

        public void FindGrandchild(Person person)
        {
            var child = person.Children;
            if (child.Count > 0)
            {
                //Tìm con của con -> In
                Console.WriteLine("----- ------ Grandchild of" + person.Name + ":");
                Console.WriteLine("----- ------ {0, -20} | {1, 15} | {2,15} | {3, 10}", "Name", "Age", "Gender", "Birthday");
                for (int i = 0; i < child.Count; i++)
                {
                    Console.WriteLine("----- ------ {0, -20} | {1, 15} | {2,15} | {3, 10}", child[i].Name, child[i].Age, child[i].Gender, child[i].Birthbay);
                }
            }
        }
    }
}
