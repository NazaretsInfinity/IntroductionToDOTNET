using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;


namespace Factorial
{

    internal class Program
    {
 
       static int factorial(int v)
        {
            for (int i = v-1; i > 0; --i) v *= i;
            return v;
        }


        static void Main(string[] args)
        {
#if checking
            Console.Write("Enter your number: ");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" it's {factorial(v)}.");

            BigInteger factor = 1;

            for (int i = v; i > 0; --i) factor *= i;
            Console.WriteLine($" its factorial is {factor}."); 
#endif

            Console.Write("Enter your number: ");
            int v = Convert.ToInt32(Console.ReadLine());
            BigInteger f = 1;
            try
            {
                for (int i = 1; i <= v; ++i)
                {
                    f *= i;
                    Console.WriteLine($"{i}! = {f}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
