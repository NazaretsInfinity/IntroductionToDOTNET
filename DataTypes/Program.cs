//#define NUMERIC_TYPES
//#define LITERALS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
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
#if NUMERIC_TYPES
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

#endif

#if LITERALS
            Console.WriteLine(123.0f.GetType());//123.1f 123f - float(single)
            Console.WriteLine(123m.GetType());//123m - decimal(Decimal)
            Console.WriteLine(5D.GetType());
            //5D - double(Double)

            //GetType return the wrapper class of type 

#endif
            #region conversions1
            //Console.WriteLine(((byte)5).GetType().Name);
            //int a = 3;
            //uint b = uint.MaxValue;
            ////a = b;


            //Console.WriteLine(a + " " + b);
            //a = (byte)5; 
            #endregion
            try
            {
                int a = int.MaxValue;
                uint b = uint.MaxValue;
                Console.WriteLine(b);
                Console.WriteLine(b.GetType());
                Console.WriteLine(a + b);
                Console.WriteLine((a + b).GetType());


                long c = long.MaxValue;
                Console.WriteLine(b + c);
                Console.WriteLine((b + c).GetType());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(b);
            }
           // uint b = uint.MaxValue;
           // Console.WriteLine(b);
        }
    }
}
