﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Students1 = new List<string>()
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

            CallOnStudents();

            void CallOnStudents()
            {
                List<string> notCalledOn = new List<string>(Students1);

                //create a list of students who have been called on
                List<string> alreadyCalledOn = new List<string>();

                Console.WriteLine("You Have NOT Called On: ");
                Console.WriteLine(String.Join(", ", notCalledOn));

                Console.WriteLine("Press any key to continue");
                Console.ReadLine();

                while (alreadyCalledOn.Count < Students1.Count)
                {
                    var random = new Random();
                    var candidate = random.Next(0, Students1.Count);

                    if (notCalledOn.Contains(Students1[candidate]))
                    {
                        alreadyCalledOn.Add(Students1[candidate]);
                        notCalledOn.Remove(Students1[candidate]);

                        Console.Write("Up Next: ");
                        Console.WriteLine(String.Join(", ", Students1[candidate]));

                        Console.WriteLine("You Have NOT Called On: ");
                        Console.WriteLine(String.Join(", ", notCalledOn));
                        Console.WriteLine("You've Already Called On: ");
                        Console.WriteLine(String.Join(", ", alreadyCalledOn));

                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                    }
                }
                
                Again();
            }

            void Again()
            {
                Console.WriteLine("You've called on all the students. Start over? Y/N?");

                string answer = Console.ReadLine().ToLower();

                while (answer != "y" && answer != "n")
                {
                    Console.Write("Please select Y or N.");
                    answer = Console.ReadLine().ToLower();
                }

                if (answer == "y")
                {
                    List<string> notCalledOn = new List<string>(Students1);
                    List<string> alreadyCalledOn = new List<string>();

                    CallOnStudents();
                }
                else
                {
                    Console.WriteLine("Thank you and good-bye!");
                    return;
                }
            }
        }
    }
}

