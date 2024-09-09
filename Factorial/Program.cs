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
 
       
      
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int v = Convert.ToInt32(Console.ReadLine());
           // for (int i = v-1; i>0 ; --i)v *= i;
            Console.WriteLine($" it's {v}.");

            BigInteger factor = 1;
            for (int i = v; i > 0; --i)factor *= i;
            Console.WriteLine($" its factorial is {factor}.");

        }
    }
}
