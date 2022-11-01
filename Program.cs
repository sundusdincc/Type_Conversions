
using System;
namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Implicit Conversion*/
            Console.WriteLine("Implicit Conversion");
            int numInt = 500;


            Type n = numInt.GetType();// get type of numInt

            double numDouble = numInt; // Implicit Conversion

            Type n1 = numDouble.GetType();// get type of numDouble

            // Value before conversion
            Console.WriteLine("numInt value: " + numInt);
            Console.WriteLine("numInt Type: " + n);

            // Value after conversion
            Console.WriteLine("numDouble value: " + numDouble);
            Console.WriteLine("numDouble Type: " + n1);
            Console.ReadLine();



            /*Explicit Conversion*/
            Console.WriteLine("Explicit Conversion");
            double numDouble1 = 1.23;

            // Explicit casting
            int numInt1 = (int)numDouble1;

            // Value before conversion
            Console.WriteLine("Original double Value: " + numDouble1);

            // Value before conversion
            Console.WriteLine("Converted int Value: " + numInt1);
            Console.ReadLine();



            /* Parse()*/
            Console.WriteLine("Parse() methodu");
            string n2 = "100";

            // converting string to int type
            int a = int.Parse(n2);
            Console.WriteLine("Original string value: " + n2);
            Console.WriteLine("Converted int value: " + a);
            Console.ReadLine();



            /*Convert Class*/
            Console.WriteLine("Convert Class");

            //int-Double-string
            // create int variable
            int num = 100;
            Console.WriteLine("int value: " + num);

            // convert int to string
            string str = Convert.ToString(num);
            Console.WriteLine("string value: " + str);

            // convert int to Double
            Double doubleNum = Convert.ToDouble(num);
            Console.WriteLine("Double value: " + doubleNum);

            Console.ReadLine();


            //int-Double-string
            // create string variable
            string str1 = "99.99";
            Console.WriteLine("Original string value: " + str1);

            // convert string to double
            Double newDouble = Convert.ToDouble(str1);
            Console.WriteLine("Converted Double value: " + newDouble);

            // create double variable
            double num1 = 88.9;
            Console.WriteLine("Original double value: " + num1);

            // converting double to string 
            string newString = Convert.ToString(num1);
            Console.WriteLine("Converted string value: " + newString);

            Console.ReadLine();

            //Boolean
            // create int variables
            int num3 = 0;
            int num4 = 1;

            // convert int to Boolean
            Boolean bool1 = Convert.ToBoolean(num3);
            Boolean bool2 = Convert.ToBoolean(num4);

            Console.WriteLine("Boolean value of 0 is: " + bool1);
            Console.WriteLine("Boolean value of 1 is: " + bool2);

            Console.ReadLine();
        }
    }



}
