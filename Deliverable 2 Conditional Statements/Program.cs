/*
 Author: Monica Costa
 Date: 1/22/2019
 Comments: This C# Console application code demonstrates the use of 
           conditional statements after getting grade input from users
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_2_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for input
            Console.WriteLine("What grade do you expect to recieve in ISM4300?");

            //Use try catch to catch bad user input
            try
            {
                //// To get user input
                string input = Console.ReadLine();
                int letterGrade = int.Parse(input);

                if (letterGrade >= 98 && letterGrade <= 100)
                {
                    Console.WriteLine("A+");
                    Console.ReadKey(true);
                }

                else if (letterGrade >= 92 && letterGrade <= 97)
                {
                    Console.WriteLine("A");
                    Console.ReadKey(true);
                }

                else if (letterGrade >= 90 && letterGrade <= 91)
                {
                    Console.WriteLine("A-");
                    Console.ReadKey(true);
                }
                else if (letterGrade >= 88 && letterGrade <= 89)
                {
                    Console.WriteLine("B+");
                    Console.ReadKey(true);
                }
                else if (letterGrade >= 82 && letterGrade <= 87)
                {
                    Console.WriteLine("B");
                    Console.ReadKey(true);
                }
                else if (letterGrade >= 80 && letterGrade <= 81)
                {
                    Console.WriteLine("B-");
                    Console.ReadKey(true);
                }
                else if (letterGrade >= 78 && letterGrade <= 79)
                {
                    Console.WriteLine("C+");
                    Console.ReadKey(true);
                }
                else if (letterGrade >= 72 && letterGrade <= 77)
                {
                    Console.WriteLine("C");
                    Console.ReadKey(true);
                }
                else if (letterGrade >= 70 && letterGrade <= 71)
                {
                    Console.WriteLine("C-");
                    Console.ReadKey(true);
                }
                else if (letterGrade >= 68 && letterGrade <= 69)
                {
                    Console.WriteLine("D+");
                    Console.ReadKey(true);
                }
                else if (letterGrade >= 62 && letterGrade <= 67)
                {
                    Console.WriteLine("D");
                    Console.ReadKey(true);
                }
                else if (letterGrade >= 60 && letterGrade <= 61)
                {
                    Console.WriteLine("D-");
                    Console.ReadKey(true);
                }
                else if (letterGrade <=59)
                {
                    Console.WriteLine("F");
                    Console.ReadKey(true);
                }

            }

            catch
            {
                Console.WriteLine("There was an error");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            } // End of catch

        } // End of main
    } // End of class
} // End of namespace
