using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if unidimensional
            //int[] arr = new int[] { 3, 5, 8, 13, 21 };
            //int[] arr = { 3, 5, 8, 13, 21 }; it's alright

            Console.Write("Enter the size of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Random rand = new Random(2); // 0 is called seed

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rand.Next(Byte.MaxValue);
            }

            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            //==========================================================================//

            int result = 0;
            int count = 0;
            foreach (int i in arr)
            {
                result += i;
                ++count;
            }
            Console.WriteLine($"Sum is {result}");

            Console.WriteLine($"Average is {(double)result/count}");


            result = arr[0];
            for (int i = 0; i < arr.Length; ++i)
            {
                if (result > arr[i]) result = arr[i];
            }
            Console.WriteLine($"That's the minimum: {result}");

            result = arr[0];
            for (int i = 0; i < arr.Length; ++i)
            {
                if (result < arr[i]) result = arr[i];
            }
            Console.WriteLine($"That's the maximum: {result}");


            //=========================================================================//
#endif
#if true2
            //int[,] arr = new int[3, 4];
            int[,] arr = new int[,]
                {
                 {3,5,8,13},
                 {21,34,55,89},
                 {144,233,377,610}
                };
            Console.WriteLine($"Amount of array dimensions: {arr.Rank}");
            Console.WriteLine($"Amount of rows in 0 dimension: {arr.GetLength(0)}");
            Console.WriteLine($"Amount of columns in 1 dimension: {arr.GetLength(1)}");
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            } 

            
#endif
#if true3
            int[][] arr = new int[][]
                {
                    new int[]{0,1,1,2 },
                    new int[]{3,5,8,13,21}

                };
            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < arr[i].Length; ++j)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
#endif       

        }
    }
}
