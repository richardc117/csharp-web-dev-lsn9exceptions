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
            if (y == 0) { throw new ArgumentOutOfRangeException("Cannot divide by 0!"); }
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            int points = 0;
            if (fileName.IndexOf(".cs") != -1) { points += 1; }
            if (fileName=="") { throw new NullReferenceException("No string value provided"); }
            return points;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            Console.WriteLine("...Attempting to divide 3 by 0..\n");
            
            try
            {
                var p = Divide(3, 0);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }


            
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


            foreach (var item in students)
            {
                try
                {
                    Console.WriteLine(CheckFileExtension(item.Value));
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
