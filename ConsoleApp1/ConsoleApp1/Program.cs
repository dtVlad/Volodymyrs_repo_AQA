using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic fixes
            /*
            Console.WriteLine("Throw exception with the original call stack and with new call stack");
            try
            {
                var b = 10;
                Console.WriteLine(b / 0);
            }

            catch (Exception a)
            {
                Console.WriteLine(a);
            }

            finally
            {


                try
                {
                    var b = 10;
                    Console.WriteLine(b / 0);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Can't divide by 0");
                }

                finally
                {
                    Console.ReadKey();
                }

            }
            */
            //RegEx Task 1
            /*
            Console.WriteLine("Create file with different text where IP address is present. " +
                "Extract it with REGEXP");

            Regex regex = new Regex(@"\b(?:[0-9]{1,3}.){3}[0-9]{1,3}\b");

            string iPlist = System.IO.File.ReadAllText(@"C:\Repos AQA\Test files AQA\RegExIp.txt");
            MatchCollection matches = regex.Matches(iPlist);
            
            foreach (var all in matches)
            {
                        Console.WriteLine(all);
            }
            */
            //RegEx Task 2

            Console.WriteLine("create a variable with some string that contains words and numbers; " +
                "create regex with groups; select a value from one of the groups to some new variable. " +
                "Take into account that the enumeration of groups starts from 1, not from 0.");

            string Sentence = "In November 1943, Franklin D. Roosevelt and Winston Churchill met with Chiang Kai-shek in Cairo and then with Joseph Stalin in Tehran. The former conference determined the post-war return of Japanese territory and the military planning for the Burma campaign, while the latter included agreement that the Western Allies would invade Europe in 1944 and that the Soviet Union would declare war on Japan within three months of Germany's defeat.";

            Regex regGr = new Regex(@".*?([\sa-zA-Z+][^\d]{1,})([\s\d+][^a-zA-Z+]{1,})?");
            Match m = regGr.Match(Sentence);
            
            while (m.Success)
            {
                string group1 = m.Groups[1].Value;
                string group2 = m.Groups[2].Value;
                Console.WriteLine("Text group: " + group1);
                Console.WriteLine("Number group: " + group2);
                m = m.NextMatch();
            }
            /*
            MatchCollection matches = regGr.Matches(Sentence);

            foreach (Match match in matches)
            {
                Console.WriteLine("Text: {0}", match.Groups[1].Value);
                Console.WriteLine("Numbers: {0}", match.Groups[2].Value);
                Console.WriteLine();
            }
            //Console.WriteLine();
            
            

            //Re

            //Task 8
            /*
            Console.WriteLine("STRINGS: StringBuilder - create, edit, available functions");

            var builder = new StringBuilder("Hello World!");
            builder.AppendLine()
                   .AppendFormat("Tom")
                   .AppendLine()
                   .Append('A', 10)
                   .AppendLine()
                   .AppendFormat("This is a tail about a brave IT Knight")
                   .Replace('i', 'I')
                   .AppendLine()
                   .Append('B', 10)
                   .Remove(75, 3)
                   .Insert(19, "is a proffessor in Cambridge University\n");


            Console.WriteLine(builder);


            //Task 7
            /*
            Console.WriteLine("Create 2 different strings.  Concatenate them and print result. " +
                "Explain what types of concatenation exists.");
            string a = "America is not a country, but a continet";
            string b = "I like pizza with salami and chili pepper";
            string[] c = {"America ", "is ", "not ", "a ", "country, ", "but a continet."};
            Console.WriteLine(a + "." + " " + b);
            Console.WriteLine($"{a}. {b}");
            Console.WriteLine(String.Concat(c));

            Console.WriteLine("\nCreate string \" egweerw  ererferw kuy yu i \". Print its length; " +
                "Trim string and print result. Print length of trimmed string.");

            string egw1 = "   egweerw  ererferw  kuy  yu i ";
            Console.WriteLine(egw1);
            Console.WriteLine(egw1.Length);
            Console.WriteLine(egw1.Trim());
            Console.WriteLine(egw1.Trim().Length);

            Console.WriteLine("\nCreate string \" egweerw  ererferw kuy yu i \"." +
                "Split string by spaces and print each value in separate row. "
                + "Clean empty spaces form result; Print each result value in a separate row. ");

            string egw2 = "   egweerw  ererferw  kuy  yu i ";
            string[] egw2Arr = egw2.Split(new string[] {}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var splW in egw2Arr)
            {
                string Modified = splW.Replace("w", "W");
                Console.WriteLine(Modified);
            }

            Console.WriteLine("\nConvert all characters to uppercase. Print result");

            string egw3 = "   egweerw  ererferw  kuy  yu i ";
            string[] egw3Arr = egw3.Split(new string[] { }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var splW in egw3Arr)
            {

                if(splW.Contains("w"))
                {
                    Console.WriteLine(splW.ToUpper());

                }
            }

            Console.WriteLine("\nConvert all 'w' to uppercase.Print result");

            string egw4 = "   egweerw  ererferw  kuy  yu i ";
            string[] egw4Arr = egw4.Split(new string[] { }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var splW in egw4Arr)
            {

                string Modified = splW.Replace("w", "W");
                Console.WriteLine(Modified);

            }

            Console.WriteLine("\nConvert first 'w' to uppercase.");

            string egw5 = "   egweerw  ererferw  kuy  yu i ";
            string[] egw5Arr = egw5.Split(new string[] { }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var splW in egw5Arr)
            {

                var regex = new Regex(Regex.Escape("w"));
                var Modified2 = regex.Replace(splW, "W", 1);
                Console.WriteLine(Modified2);

            }

            Console.WriteLine("\nCreate string \"this item previous price $5.99, Sale price $1.99. \" " +
                "- parse original and sale price from string and print them.");

            string price = "this item previous price $5.99, Sale price $1.99. ";
            MatchCollection allPrices = Regex.Matches(price, @"[$](\d...)");
            var pricesSet = new List<string>();

            foreach (var prices in allPrices)
            {
                pricesSet.Add(Convert.ToString(prices));    
            }

            Console.WriteLine("Old price was " + "$" + pricesSet[0]);
            Console.WriteLine("New price is " + "$" + pricesSet[1]);

            //Task 6
            /*
            Console.WriteLine("Create FIle. Set text into file with digits and letters, where digits are in separate line. " +
                "Read digits from the file and make some math operations with them");

            string[] text = System.IO.File.ReadAllLines(@"C:\Repos AQA\Test files AQA\TestAQA.txt");

            var Numbers = new List<int>();
            foreach (var all in text)
            {
                try
                {
                    if (Convert.ToInt32(all) is int)
                    {
                        Console.WriteLine(all);
                        Numbers.Add(Convert.ToInt32(all));

                    }
                }
                catch(Exception)
                {

                }
            }
            Console.WriteLine(Numbers.Sum());
            Console.WriteLine(Numbers[0] - Numbers[3]);
            Console.WriteLine(Numbers[2] * Numbers[3]);
            Console.WriteLine(Numbers[0] - Numbers[2]);
            Console.WriteLine(Numbers[3] / Numbers[2]);

            //Task 5

            /*

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
