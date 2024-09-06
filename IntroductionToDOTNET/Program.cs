#define OUTPUT_TO_SCREEN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {

#if OUTPUT_TO_SCREEN1
            Console.Title = "Introduction to .NET";
            Console.WriteLine("Hello .NET");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.CursorLeft = 24; //X coordinate of cursor
            //Console.CursorTop = 7; // Y coordinate of cursor
            Console.SetCursorPosition(16, 5);
            Console.WriteLine("Here how we set coordinates.");
            Console.ResetColor(); //deletes colors we set before

            //set console window size 
            // Console.WindowWidth = 44;
            // Console.WindowHeight = 16;
            Console.SetWindowSize(64, 24);

            #region CodeSnippet
            //set console window position on the screen
            //Console.WindowLeft = 10;
            //Console.WindowTop = 10; 
            #endregion
            // #region allows to roll up a part of code.

            Console.SetWindowPosition(0, 0);

            //set size of console buffer
            Console.BufferWidth = Console.WindowWidth; ;
            Console.BufferHeight = Console.WindowHeight;

#endif
            Console.Write("Enter your name: ");
            string first_name = Console.ReadLine();
            //ReadLine() reads the STRING from the keyboard till the Enter.
            // it returns the string it read.
            


            Console.Write("Enter your surname: ");
            string last_name = Console.ReadLine();
            

            //Class convert is a set of static methods for
            // type conversions. this class we use when 
            //other conversions doesn't work

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(last_name + " " + first_name + ", " + age + " years");
            //concatenation
            //beside the concatenations of string, C# provides formatting of strings
            Console.WriteLine(String.Format("{0} {1}, {2} years", last_name, first_name, age));

            //interpolation of strings
            Console.WriteLine($"{last_name} {first_name}, {age} years");    
        }
    }
}
