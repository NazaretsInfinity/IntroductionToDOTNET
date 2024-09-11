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


#if true1
            Random rand = new Random();
            int x = (rand.Next(Console.WindowWidth));
            int y = (rand.Next(Console.WindowHeight));
            Console.WriteLine($"X = {x}   Y = {y}");
         
            Console.SetCursorPosition(x, y);


            ConsoleKey key;
            Console.CursorVisible = false;
            //CursorVisible - false = to make the cursor unseen on the console
            char symbol = (char)2;
            Console.WriteLine(symbol);
            do
            {
                
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.RightArrow: ++x; break;
                    case ConsoleKey.D: ++x; break;
                    case ConsoleKey.LeftArrow: --x; break;
                    case ConsoleKey.A: --x; break;
                    case ConsoleKey.UpArrow: --y; break;
                    case ConsoleKey.W: y--; break;
                    case ConsoleKey.DownArrow: ++y; break;
                    case ConsoleKey.S: ++y; break;
                }
                if (y < 1) y = 0;
                if (x < 0) x = 0;
                if (y > Console.BufferHeight - 1) y = Console.BufferHeight - 1;
                if (x > Console.BufferWidth - 1) y = Console.BufferWidth - 1;
                Console.Clear();
                Console.WriteLine($"X = {x}   Y = {y}");
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            } while (key != ConsoleKey.Escape);
           
#endif

#if true
            Console.Write("Enter what to solve: ");
            string s = Console.ReadLine();

            string[] tokens = s.Split('+', '-', '*', '/', '=');

            double result = 0;
            double a = Convert.ToDouble(tokens[0]);
            double b = Convert.ToDouble(tokens[1]);

            if (s.Contains('+')) result = a + b;
            //'Contains' determines if the string have a symbol or substring(type it in parameters) 
            else if (s.Contains("-")) result = a - b;
            else if (s.Contains("*")) result = a * b;
            else if (s.Contains("/")) result = a / b;
            else Console.Write("No ar.operations.  ");

            Console.WriteLine($"It's {result}"); 
#endif




#if true3


      Console.Write("Enter what to solve: ");
            string s = Console.ReadLine();
            char[] dels = { '+', '-', '*', '/', '=' };
            
            string[] tokens = s.Split(dels);


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

              numbers = null;
#endif
        }
    }
}
