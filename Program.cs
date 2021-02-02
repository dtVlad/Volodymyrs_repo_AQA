using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create 5 variables with type int,long,float,double,String
            int int1 = 1000;
            long long1 = 70700;
            float float1 = 20.11f;
            double double1 = 99.9;
            string string1 = "Hello!";
            string string2 = "12345";

            //Assing different values to these variables and compare them.
            int edge1 = Convert.ToInt32(2147483647);
            long edge2 = Convert.ToInt64(9223372036854775807);
            float edge3 = 20.12345678f;
            double edge4 = 20.12345678123456781234567812345678;
            string edge5 = edge4.ToString();
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", edge1, edge2, edge3, edge4, edge5);

            //Assign the same values and compare variables
            Console.WriteLine("Default data types");
            int one = (int)long1;
            int two = (int)float1;
            int three = (int)double1;
            int four = Int32.Parse(string2);
            Console.WriteLine("{0}, {1}, {2}, {3}", one, two, three, four);


            // long long1 = Convert.ToInt64(int1);
        }
    }
}
