using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 5

            Console.WriteLine("Use \"try catch\"  to process the exceptions. Check Exception Hierarchy.");

            try
            {
                throw new InvalidOperationException("Logfile cannot be read-only");
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("Exception processed");
            }

            Console.WriteLine("Create a numeric variable. Divide it by zero. " +
                "Handle exception and print in console exception message;");
            try
            {
                var a = 10;
                Console.WriteLine(a / 0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Throw exception with the original call stack and with new call stack");
            try
            {
                var b = 10;
                Console.WriteLine(b / 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("\nStackTrace\n");
            try
            {
                var b = 10;
                Console.WriteLine(b / 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }


            //Task 4
            /*
            Console.WriteLine("Create array, lists, dictionaries, ReadOnlyCollection, and tuples.");
            int[] MyArray = { 1, 2, 3, 4 };

            var MyList = new List<string>() {"Cat", "Dog", "Cow", "Horse" };

            var ROCList = new List<string>() { "Cat", "Dog", "Cow", "Horse" };

            var MyDictionary = new Dictionary<int, string>()
            {
                {1, "Ukraine, Poland" },
                {2, "Europe, Asia" },
                {3, "Earth, Venus" }
            };

            ReadOnlyCollection<string> MyROC = new ReadOnlyCollection<string>(ROCList);

            var Me = Tuple.Create(1992, "Vova", "QA", "Lviv", 176.00);

            Console.WriteLine("Try to use them in methods: Add, Remove, Find element");

            Console.WriteLine("Add");

            MyList.Add("Pony");
            foreach (var Animals in MyList)
            Console.WriteLine(Animals);

            MyDictionary.Add(4, "Milky Way, Sombrero Galaxy");
            string NewDictionaryItem = MyDictionary[4];
            Console.WriteLine(NewDictionaryItem);

            Console.WriteLine("Remove");
            MyList.Remove("Cow");
            foreach (var Animals in MyList)
            Console.WriteLine(Animals);

            MyDictionary.Remove(3);
            foreach(KeyValuePair<int, string> kvp in MyDictionary)
            Console.WriteLine(kvp);

            Console.WriteLine("Find element");

            if (MyDictionary.ContainsKey(1))
            {
                Console.WriteLine("Ukraine, Poland");
            }

            var FindArray = new string[3] { "Car", "Train", "Boat" };


            string FindEl = Array.Find(FindArray, ele => ele.StartsWith("B",
            StringComparison.Ordinal));
            Console.WriteLine(FindEl);*/

            /*MyROC.Add("Pony");
            foreach (var Animals in MyROC)
            Console.WriteLine(Animals);
            Error
            */

            //Task 3
            /*
            Console.WriteLine("use cycles \"for\",  \"while\",  \"foreach\", \"do while\" Cycle operators ");
            Console.WriteLine("\nCreate for, while, do while cycles that iterate 10 times and print iteration number to console. ");

            Console.WriteLine("\nfor");
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\nwhile");
            int w = 0;
            while(w < 10)
            {
                Console.WriteLine(w);
                w++;
            }

            Console.WriteLine("\ndo while");
            int d = 0;
            do
            {
                Console.WriteLine(d);
                d++;
            }
            while (d < 10);

            Console.WriteLine("\nforeach");

            byte[] myYear = { 1, 9, 9, 2 };
            foreach (byte year in myYear)
            {
                Console.WriteLine(year);
            }

            Console.WriteLine("\nCreate recursion with exit condition");

            int factorial(int n)
            {
                if (n == 0)
                    return 1;
                else
                    return n * factorial(n - 1);
            }

            Console.WriteLine(factorial(5));
            */
            /*Console.WriteLine("\nCreate recursion without exit condition");

            int factorialTwo(int n)
            {
                if (n == 0)
                    return 1;
                else
                    return n * factorialTwo(n);
            }

            Console.WriteLine(factorialTwo(1));*/

            //Console.WriteLine("\nCreate an infinite loop.");
            //
            //for (int a = 0; a > -1; a++)
            //{
            //    Console.WriteLine(a);
            //}



            ////Task 2
            //
            //Console.WriteLine("use conditions \"if\" and  \"switch case\"Create 4 boolean variables(true,true,false,false) and compare them between themselves");
            //
            //var trueOne = true;
            //var trueTwo = true;
            //var falseOne = false;
            //var falseTwo = false;
            //
            //
            //Console.WriteLine("If statement");
            //if (trueOne == trueTwo)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if (trueOne == falseOne)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if (falseOne == trueOne)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if (falseOne == falseTwo)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //
            //Console.WriteLine("\nSwitch case statement");
            //
            //bool resultOne = trueOne == trueTwo ? true : false;
            //switch (resultOne)
            //{
            //    case true:
            //        Console.WriteLine("True");
            //        break;
            //    case false:
            //        Console.WriteLine("False");
            //        break;
            //}
            //bool resultTwo = trueOne == falseOne ? true : false;
            //switch (resultTwo)
            //{
            //    case true:
            //        Console.WriteLine("True");
            //        break;
            //    case false:
            //        Console.WriteLine("False");
            //        break;
            //}
            //
            //Console.WriteLine("Create 4 different numeric variables and compare them with the usage of <,<=,!=,==,===,>=,>");
            //int a = 77;
            //int b = 1000;
            //int c = -255;
            //float f = 77.00f;
            //
            //Console.WriteLine(a != b);
            //Console.WriteLine(a == b);
            //Console.WriteLine(a == f);
            //Console.WriteLine(b >= c);
            //Console.WriteLine(a <= f);
            //Console.WriteLine(a > b);
            //Console.WriteLine(a >= b);
            //Console.WriteLine(c < a);
            //
            //Console.WriteLine("\nCreate 2 different strings. Compare them with usage if trinar operator and print \"Not equal\", \"Equal\" and explain");
            //string firstString = "I love milk";
            //string secondString = "I don't love milk";
            //Console.WriteLine(firstString == secondString ? "Equal" : "Not Equal");
            //
            //Console.WriteLine("Explain difference betweeb &&,|| and provide example");
            //var thisTrue = true;
            //var thisFalse = false;
            //Console.WriteLine(thisTrue && thisFalse);
            //Console.WriteLine(thisTrue || thisFalse);
            //Console.WriteLine(!(thisTrue && thisFalse));
            //
            //Console.WriteLine("\n Create 2 string variables with same value but initialize one with literal \nand another with constructor.(String a =\"lalala\";\" + \"String b = new String(\"lalala\");) Compare this values with usage of == and equal.");
            //String verbatimString = @"lalala";
            //String concatString = String.Concat("la", "la", "", "la");
            //Console.WriteLine(verbatimString = concatString);
            //Console.WriteLine(verbatimString == concatString);
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
