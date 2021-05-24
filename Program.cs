using System;
using System.Collections.Generic;
using System.Linq;

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
            var random = new Random();
            List<int> Indexes = new List<int>();

            //chooses a candidate at random
            var candidate = random.Next(0, Students.Length);

            List<int> AlreadyCalledOn = new List<int>();

            while (Indexes.Count < 1)
            {

                if (!Indexes.Contains(candidate))
                {
                    Indexes.Add(candidate);
                    AlreadyCalledOn.Add(candidate);
                }

            }

            for (int i = 0; i < Indexes.Count; i++)
            {
                int index = Indexes[i];
                Console.WriteLine(Students[index]);
            }

            var candidateString = String.Join(", ", Indexes);
            var AlreadyCalledOnString = String.Join(" ,", AlreadyCalledOn);

            Console.WriteLine(candidateString);
            Console.WriteLine(AlreadyCalledOnString);
        }
    }
}
