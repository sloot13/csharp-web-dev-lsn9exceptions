using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("you cannot divide by zero!!!");
            }


            return x / y;


        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if (fileName == "" || fileName == null) { throw new ArgumentOutOfRangeException("didn't submit a file"); }
            if (fileName[fileName.Length-1] == 's' && fileName[fileName.Length - 2] == 'c') { return 1; }


            return 0;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Console.WriteLine(Divide(3, 2));
                Console.WriteLine(Divide(3, 1));
                Console.WriteLine(Divide(3, -1));
                Console.WriteLine(Divide(3, 0));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Test out your CheckFileExtension() function here!

            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            Dictionary<string, string>.KeyCollection keyColl = students.Keys;

            foreach (string s in keyColl)
            {
                try
                {
                    Console.WriteLine(CheckFileExtension(students[s]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            


        }
    }
}
