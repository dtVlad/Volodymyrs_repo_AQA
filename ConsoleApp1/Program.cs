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
            //Task 2

            //use conditions "if" and  "switch case"Create 4 boolean variables(true,true,false,false) and compare them between themselves

            var trueOne = true;
            var trueTwo = true;
            var falseOne = false;
            var falseTwo = false;


            Console.WriteLine("If statement");
            if (trueOne == trueTwo)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            if (trueOne == falseOne)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            if (falseOne == trueOne)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            if (falseOne == falseTwo)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
            Console.WriteLine("\nSwitch case statement");

            bool resultOne = trueOne == trueTwo ? true : false;
            switch (resultOne)
            {
                case true:
                    Console.WriteLine("True");
                    break;
                case false:
                    Console.WriteLine("False");
                    break;
            }
            bool resultTwo = trueOne == falseOne ? true : false;
            switch (resultTwo)
            {
                case true:
                    Console.WriteLine("True");
                    break;
                case false:
                    Console.WriteLine("False");
                    break;
            }

            Console.WriteLine("Create 4 different numeric variables and compare them with the usage of <,<=,!=,==,===,>=,>");
            int a = 77;
            int b = 1000;
            int c = -255;
            float f = 77.00f;

            Console.WriteLine(a != b);
            Console.WriteLine(a == b);
            Console.WriteLine(a == f);
            Console.WriteLine(b >= c);
            Console.WriteLine(a <= f);
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(c < a);

            Console.WriteLine("\nCreate 2 different strings. Compare them with usage if trinar operator and print \"Not equal\", \"Equal\" and explain");
            string firstString = "I love milk";
            string secondString = "I don't love milk";
            Console.WriteLine(firstString == secondString ? "Equal" : "Not Equal");

            Console.WriteLine("Explain difference betweeb &&,|| and provide example");
            var thisTrue = true;
            var thisFalse = false;
            Console.WriteLine(thisTrue && thisFalse);
            Console.WriteLine(thisTrue || thisFalse);
            Console.WriteLine(!(thisTrue && thisFalse));

            Console.WriteLine("\n Create 2 string variables with same value but initialize one with literal \nand another with constructor.(String a =\"lalala\";\" + \"String b = new String(\"lalala\");) Compare this values with usage of == and equal.");
            String verbatimString = @"lalala";
            String concatString = String.Concat("la", "la", "", "la");
            Console.WriteLine(verbatimString = concatString);
            Console.WriteLine(verbatimString == concatString);
            /*Task 1
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

            /*//Assign the same values and compare variables

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

            /*//Assign in same order [0.5,0.7,1.0,0.1] values to float and double variables and compare them
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
            */
        }
    }
}
