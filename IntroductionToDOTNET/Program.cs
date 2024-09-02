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

            //set console window position on the screen
            //Console.WindowLeft = 10;
            //Console.WindowTop = 10;

            Console.SetWindowPosition(0, 0);

            //set size of console buffer
            Console.BufferWidth = Console.WindowWidth; ;
            Console.BufferHeight = Console.WindowHeight;

        }
    }
}
