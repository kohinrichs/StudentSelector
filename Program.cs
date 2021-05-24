using System;
using System.Collections.Generic;

namespace StudentSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Students =
           {
               "Chad Clark",
                "Micaela Colpi",
                "Sidney Crandall",
                "Salma Crank",
                "Carter Culkin",
                "David Darden",
                "Logan Demmy",
                "Chris Douglass",
                "Alex Dudley",
                "Autumn Fotopoulos",
                "Joel Gage",
                "Bryson Goins",
                "B.J. Golden",
               "Jackson Goodman",
                "Brandon Hill",
                "Traye Johnson",
                "Cody Jones",
                "Bre Coach",
                "Taryn Lytle",
                "Ethan Mathis",
                "Colten Mayberry",
                "Meg McGregor",
                "Laurel Morrison",
                "Nick Patton",
                "Hunter Preast",
                "Jeremiah Schugt",
                "Preston Shotts",
                "Brandon Vinson",
                "Dakota Upchurch"
            };
            //creates a list of index values
            List<int> Indexes = new List<int>();
            while (Indexes.Count < 1)
            {
                var random = new Random();
                int candidate = random.Next(Students.Length);
                if (!Indexes.Contains(candidate))
                {
                    Indexes.Add(candidate);
                }
            }

            for (int i = 0; i < Indexes.Count; i++)
            {
                int index = Indexes[i];
                Console.WriteLine(Students[index]);
            }
        }
    }
}
