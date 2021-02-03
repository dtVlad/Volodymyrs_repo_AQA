using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 5 variables with type int,long,float,double,String
            int int1;
            long long1;
            float float1;
            double double1;
            string string1;

            int intSame;
            long longSame;
            float floatSame;
            double doubleSame;
            string stringSame;

            //Assing different values to these variables and compare them.

            int1 = 1000;
            long1 = 80000;
            float1 = 99.99f;
            double1 = 1234.59696964;
            string1 = "123456789";
            Console.WriteLine("\nAssing different values to these variables and compare them");
            Console.WriteLine("Int results");
            Console.WriteLine(int1 == long1);
            Console.WriteLine(int1 == float1);
            Console.WriteLine(int1 == double1);
            Console.WriteLine(int1 == Int32.Parse(string1));
            Console.WriteLine("Float results");
            Console.WriteLine(float1 == long1);
            Console.WriteLine(float1 == double1);
            Console.WriteLine(float1 == Int32.Parse(string1));
            Console.WriteLine("String results");
            Console.WriteLine(Int32.Parse(string1) == long1);
            Console.WriteLine(Int32.Parse(string1) == double1);


            /*int edge1 = Convert.ToInt32(2147483647);
            long edge2 = Convert.ToInt64(9223372036854775807);
            float edge3 = 20.12345678f;
            double edge4 = 20.12345678123456781234567812345678;
            string edge5 = edge4.ToString();
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", edge1, edge2, edge3, edge4, edge5);*/

            //Assign the same values and compare variables

            intSame = 1000;
            longSame = 1000;
            floatSame = 1000.0000f;
            doubleSame = 1000.00000;
            stringSame = "1000";
            Console.WriteLine("\nAssign the same values and compare variables");
            Console.WriteLine("Int results");
            Console.WriteLine(intSame == longSame);
            Console.WriteLine(intSame == floatSame);
            Console.WriteLine(intSame == doubleSame);
            Console.WriteLine(intSame == Int32.Parse(stringSame));
            Console.WriteLine("Float results");
            Console.WriteLine(floatSame == longSame);
            Console.WriteLine(floatSame == doubleSame);
            Console.WriteLine(floatSame == Int32.Parse(stringSame));
            Console.WriteLine("String results");
            Console.WriteLine(Int32.Parse(stringSame) == longSame);
            Console.WriteLine(Int32.Parse(stringSame) == doubleSame);

            /*Console.WriteLine("Default data types");
            int one = (int)long1;
            int two = (int)float1;
            int three = (int)double1;
            int four = Int32.Parse(string1);
            Console.WriteLine("{0}, {1}, {2}, {3}", one, two, three, four);*/


            // long long1 = Convert.ToInt64(int1);

            //Assign in same order [0.5,0.7,1.0,0.1] values to float and double variables and compare them
            Console.WriteLine("\nAssign in same order [0.5,0.7,1.0,0.1] values to float and double variables and compare them");
            float numberOne;
            float numberTwo;
            double numberThree;
            double numberFour;
            numberOne = 0.5f;
            numberTwo = 1.0f;
            numberThree = 0.7;
            numberFour = 0.1;
            Console.WriteLine(numberOne == numberThree);
            Console.WriteLine(numberTwo == numberFour);

            //Divide numeric values by zero
            Console.WriteLine("\nDivide numeric values by zero");
            //var DivideByZeroException = int1 / 0;v EXCEPTION
           // Console.WriteLine(DivideByZeroException);

            //Divide values by 3 and assign result to variable
            float floatN = 10f;
            double doubleN = 77;
            int intN = 10000000;
            long longN = 92939499596;
            string stringN = "777777777777";
            Console.WriteLine("\nDivide values by 3 and assign result to variable");
            var divFloat = floatN / 3;
            var divDouble = doubleN / 3;
            var divInt = intN / 3;
            var divLong = longN / 3;
            double divString = double.Parse(stringN) / 3; //doesn't become decimal
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", divFloat, divDouble, divInt, divLong, divString);

            //Divide values by 3.0 and assign result and make round operation
            Console.WriteLine("\nDivide values by 3.0 and assign result and make round operation");
            var roundFloat = floatN / 3;
            var roundDouble = doubleN / 3;
            var roundString = double.Parse(stringN) / 3; 
            Console.WriteLine("{0}, {1}, {2}", Math.Round(roundFloat), Math.Round(roundDouble), Math.Round(roundString));
        }
    }
}
