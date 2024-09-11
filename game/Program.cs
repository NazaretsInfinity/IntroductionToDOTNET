using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {


#if game
            Random rand = new Random();
            int x = (rand.Next(Console.WindowWidth));
            int y = (rand.Next(Console.WindowHeight));
            Console.SetCursorPosition(x, y);

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
                    case ConsoleKey.UpArrow: Console.SetCursorPosition(x, --y); break;
                    case ConsoleKey.W: Console.SetCursorPosition(x, --y); break;
                    case ConsoleKey.DownArrow: Console.SetCursorPosition(x, ++y); break;
                    case ConsoleKey.S: Console.SetCursorPosition(x, ++y); break;
                }
            } while (key != ConsoleKey.Escape); 
#endif

            Console.Write("Enter what to solve: ");
            string s = Console.ReadLine();
            char[] dels = { '+', '-', '*', '/', '=' };
            
            string[] tokens = s.Split(dels);



            double result = 0;
            double a = Convert.ToDouble(tokens[0]);
            double b = Convert.ToDouble(tokens[1]);
           


            if (s.Contains('+')) result = a+b;
            else if (s.Contains("-")) result = a-b;
            else if (s.Contains("*")) result = a*b;
            else if (s.Contains("/")) result = a/b;

            Console.WriteLine($"It's {result}");


#if inprogress


            double[] numbers = new double[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                numbers[i] = Convert.ToDouble(tokens[i]);
            }

            char[] delsop = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] chars = s.Split(delsop);



            double result = numbers[0];

            for (int i = 0; i < numbers.Length - 1; ++i)
            {

                switch (Convert.ToChar(chars[i + 1]))
                {
                    case '+': result += numbers[i + 1]; break;
                    case '-': result -= numbers[i + 1]; break;
                    case '*': result *= numbers[i + 1]; break;
                    case '/': result /= numbers[i + 1]; break;
                    default: continue;
                }

            }
              Console.WriteLine($"It's {result}");
#endif
        }
    }
}
