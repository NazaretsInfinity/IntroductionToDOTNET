using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.Write("Enter where to start: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            int x = (rand.Next(Console.WindowWidth));
            int y = (rand.Next(Console.WindowHeight));
            Console.SetCursorPosition(x,y);

            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.RightArrow: Console.SetCursorPosition(++x, y); break;
                    case ConsoleKey.D: Console.SetCursorPosition(++x, y); break;
                    case ConsoleKey.LeftArrow: Console.SetCursorPosition(x--, y); break;
                    case ConsoleKey.A: Console.SetCursorPosition(x--, y); break;
                    case ConsoleKey.UpArrow: Console.SetCursorPosition(x, --y);break;
                    case ConsoleKey.W: Console.SetCursorPosition(x, --y);break;
                    case ConsoleKey.DownArrow: Console.SetCursorPosition(x, ++y);break;
                    case ConsoleKey.S: Console.SetCursorPosition(x, ++y);break;
                }
            } while (key!= ConsoleKey.Escape);
        }
    }
}
