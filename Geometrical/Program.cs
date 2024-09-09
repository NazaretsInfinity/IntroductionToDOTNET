using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrical
{
    internal class Program
    {
        static readonly string delimeter = "\n---------------------------\n";
        static void Main(string[] args)
        {
            Console.Write("Enter the size: ");
            int s = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < s; ++i)
            {
                for (int j = 0; j < s; ++j)Console.Write("*");
                Console.WriteLine();
            }
            Console.Write(delimeter);

            for (int i = 0; i < s; ++i)
            {
                for (int j = 0; j <= i; ++j) Console.Write("*");
                Console.WriteLine();
            }
            Console.Write(delimeter);

            for (int i = s; i > 0; --i)
            {
                for (int j = i; j > 0; --j) Console.Write("*");
                Console.WriteLine();
            } Console.WriteLine(delimeter);

            for (int i = s; i > 0; --i)
            {
                for (int j = s; j > 0; --j)Console.Write(j <= i ? "*" : " ");
                Console.WriteLine();
            }
            Console.Write(delimeter);


            for (int i = s; i > 0; --i)
            {
                for (int j = 0; j < s; ++j)Console.Write(j < i - 1 ? " " : "*");
                Console.WriteLine();
            }
            Console.Write(delimeter);

            //rhombus
            for (int i = 0; i <= s * 2; ++i)
            {
                for (int j = 0; j < s * 2; ++j)
                {
                    if (i <= s)
                    {
                        if (j < s) Console.Write(j == s - i ? "/" : " ");
                        else Console.Write(j == s + i - 1 ? "\\" : " ");
                    }

                    else
                    {
                        if (j < s) Console.Write(j == i - s - 1 ? "\\" : " ");
                        else Console.Write(s * 2 - j == i - s ? "/" : " ");
                    }
                }
                Console.WriteLine();

            }
            Console.Write(delimeter);

            //chess
            for(int i = 0; i < s;++i)
            {
                for(int j = 0;j < s; ++j)Console.Write(j%2==i%2 ? "+ " : "- ");    
                Console.WriteLine();
            }
            Console.Write(delimeter);


            for (int i = 0; i <= s; ++i)
            {
                for (int k = 0; k <= s; ++k)
                {
                    if (i == 0 && k == 0) Console.Write(Convert.ToChar(0x250F));
                    else if (i == 0 && k == s) Console.Write(Convert.ToChar(0x2513));
                    else if (i == s && k == s) Console.Write(Convert.ToChar(0x251B));
                    else if (i == s && k == 0) Console.Write(Convert.ToChar(0x2517));
                    else if (i == 0 || i == s) Console.Write((char)0x2501);
                    else if (k == 0 || k == s) Console.Write(Convert.ToChar(0x2503));
                    else Console.Write(i % 2 == k % 2 ? Convert.ToChar(0x2588) : ' ');
                }
                Console.WriteLine();
            }
            Console.Write(delimeter);

            //hard-chess
#if reserve
            for (int i = 0; i < s * 5; ++i)
            {
                for (int j = 0; j < 5 * s; ++j)
                    Console.Write((j % 10 < 5 && i % 10 < 5) || (j % 10 >= 5 && i % 10 >= 5) ? "* " : "  ");
                Console.WriteLine();
            } 
#endif
            for (int i = 0; i < s * 5; ++i)
            {
                for (int j = 0; j < 5 * s; ++j)
                    Console.Write( j==i ? "* " : "  ");
                Console.WriteLine();
            }
        }
    }
}
