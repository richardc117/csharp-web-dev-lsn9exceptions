using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            int points = 0;
            if (fileName.IndexOf(".cs") != -1) { points += 1; }
            if (fileName.IndexOf(".cs") == -1) { Console.Write("No .cs file extension!  "); }
            return points;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            Console.WriteLine("...Attempting to divide 3 by 0..\n");
            var p = Divide(3, 0);
            Console.Write("Result:  ");
            if (double.IsInfinity(p))
            {
                Console.WriteLine("Cannot divide by 0!");
            }

            
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


            foreach (var item in students)
            {
                Console.WriteLine(CheckFileExtension(item.Value));
            }
        }
    }
}
