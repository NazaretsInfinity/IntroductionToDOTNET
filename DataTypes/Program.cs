using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static readonly string delimeter1 = "\n---------------------------\n";
        static readonly string delimeter2 = "\n===========================\n";
        static void Main(string[] args)
        {
            #region Boolean
            Console.WriteLine("C#, DataTypes");
            Console.WriteLine(Convert.ToBoolean(-1));
            Console.WriteLine(Convert.ToBoolean(0));

            Console.WriteLine(bool.Parse("true"));
            #endregion

            #region short(Int16)
            Console.Write(delimeter2);
            Console.WriteLine($"Type 'short' takes {sizeof(short)} bytes");
            Console.WriteLine($"and takes values in range: {short.MinValue} to {short.MaxValue}.");
            Console.Write(delimeter1);
            Console.WriteLine($"or either in range: {UInt16.MinValue} to {UInt16.MaxValue}.");
            Console.Write(delimeter2);
            //envelop class for type 'short' is Int16 (for ushort - Uint16) 
            #endregion

            #region Int(Int32)
            Console.WriteLine($"Type 'int' takes {sizeof(int)} bytes");
            Console.WriteLine($"and takes values in range: {int.MinValue} to {int.MaxValue}.");
            Console.Write(delimeter1);
            Console.WriteLine($"or either in range: {UInt32.MinValue} to {UInt32.MaxValue}.");
            Console.Write(delimeter2);
            //type long takes 8 bytes
            //its envelope-class is Int64 or UInt64
            #endregion

        }
    }
}
