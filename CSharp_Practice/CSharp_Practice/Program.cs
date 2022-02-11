//Namespace Declaration
using System;

namespace CSharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //C# Tutorial - Introduction

            //Write to console
            Console.WriteLine("Welcome to C# Training!");
            Main1();


            //C# Tutorial - Reading and writing to a console

            //Example 1

            //Prompt the user for his name
            Console.WriteLine("Please enter your name");

            //Read the name from console
            var username = Console.ReadLine();

            //Concatenate name with hello word and print
            Console.WriteLine("Hello " + username);

            //Example 2

            Console.WriteLine("Please enter your first name");

            var firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name");

            var lastname = Console.ReadLine();

            //Placeholder syntax to print name with hello word -Most Preferred
            Console.WriteLine("Hello {0}", username);
            Console.WriteLine("Hello {0} {1}", firstname, lastname);


            //Note: C# is case sensitive

            //C# Tutorial - Built - in types

            Console.WriteLine("Min = {0}", int.MinValue);
            Console.WriteLine("Max = {0}", int.MaxValue);


            //C# Tutorial - String type in c#

            //Escape Sequence

            string a = "\"arafat\"";
            string b = "one\ntwo\nthree";
            string c = "D:\\Web Development\\aspdotnet_practice"; //Without Verbatim Literal - Less Readable

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //Verbatim Literal

            string d = @"D:\Web Development\aspdotnet_practice"; //With Verbatim Literal - Better Readable
            Console.WriteLine(d);


            //C# Tutorial - Common Operators in c#

            int a2 = 10;
            int b2 = 2;
            int c2 = 0;

            bool number10 = (a2 == 10) ? true : false; //Ternary Operator

            Console.WriteLine("Number 10 is {0}", number10);


            if (a2 == 10 && b2 == 2)
            {
                c2 = a2 / b2;
                Console.WriteLine(c);
            }

            //C# Tutorial - Nullable Types

            //string name = null; Reference Type - Default value of reference type is null, all reference type are nullable

            //int i = null; Value Type -Default value of value type is some form of zero (non-nullable variable), by default value type are not nullable

            //int? j = null;  nullable variable, value type can be nullable by using ? mark after variable type

            //bool? a = null; nullable variable

            //Example 1

            bool? AreYouMajor = null;

            if(AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if(AreYouMajor == false)
            {
                Console.WriteLine("User is not Major");

            }
            else
            {
                Console.WriteLine("User did not answer the question");
            }

            //Example 2 - option 1 (Normal way)

            int? TicketOnSale = null;

            int AvailableTickets = 0;

            if(TicketOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                //AvailableTickets = TicketOnSale.Value; nullable to non - nullable conversion
                AvailableTickets = (int)TicketOnSale;
            }

            Console.WriteLine("Available Tickets: {0}", AvailableTickets);

            //Example 2 - option 2 (Using Null Coalescing operator ??)

            int? TicketOnSale2 = null;

            // Null Coalescing operator ??
            int AvailableTickets2 = TicketOnSale2 ?? 0;

            Console.WriteLine("Available Tickets: {0}", AvailableTickets2);

            //C# Tutorial Datatypes conversion

            //implicit conversion

            //Example - 1

            int i = 100;

            //Float is a bigger datatype than int. So, No loss of data and Exceptions. Hence implicit conversion
            float f = i;

            Console.WriteLine(f);

            //explicit conversion

            //Example - 2

            float f2 = 125.43F; //Cannot implicitly convert float to int. Fractional part will be lost.
                                //Float is a bigger datatype than int, so there is also a possibility of overflowException
                                //int i = f;

            //int i2 = (int)f2;  //use type cast () operator for explicit conversion, type cast () operator never throw exception if it can not convert that float to int

            int i2 = Convert.ToInt32(f2);  //use Convert class of DotNet for explicit conversion, 
                                           //Convert class throw OverFlowException if that float value is too large or small to convert into int.
                                           //OverflowException: The exception that is thrown when an arithmetic, casting, or conversion operation in a checked context results in an overflow.
                                           //An OverflowException is thrown at run time, so this is a runtime exception.

            Console.WriteLine(i2);


            //Parse method () - Use Parse() if you are sure the value will be valid, otherwise use TryParse()

            //Example - 3

            string strNumber = "100";

            int i3 = int.Parse(strNumber);

            Console.WriteLine(i3);

            //Example - 4

            string strNumber2 = "100TG";

            int i4 = int.Parse(strNumber2); //FormatException: Input string was not in a correct format.
                                            //Parse method () throw an exception if it cannot parse the value
                                            //FormatException: The exception that is thrown when the format of an argument is invalid, or when a composite format string is not well formed.
                                            //An FormatException is thrown at run time, so this is a runtime exception.


            Console.WriteLine(i4);


            //TryParse method ()

            //Example - 5

            string strNumber3 = "100TG";

            int Result = 0;

            bool IsConversionSuccessful = int.TryParse(strNumber3, out Result); //TryParse method () returns a bool indication whether it succeeded or failed
                                            
            if(IsConversionSuccessful)
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Enter a valid Number");
            }

            //C# Tutorial - Arrays in C#
            //Arrays: An array is a collection of similar data types.

            //Example - 1

            //Initialize and Assign Values in difference lines
            int[] EvenNumbers = new int[3];

            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;
            EvenNumbers[3] = 6; //IndexOutofRangeException: Index was out the bounds of the array.
                                //IndexOutOfRangeException: The exception that is thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds.
                                //The IndexOutOfRangeException is a Runtime Exception thrown only at runtime.

            Console.WriteLine(EvenNumbers[2]);

            //Initialize and Assign Values in difference lines

            //Example - 2

            int[] OddNumbers = { 1,3,5 };

            Console.WriteLine(OddNumbers[2]);


            //Example - 3

            //Initialize and Assign Values in difference lines
            int[] EvenNumbers2 = new int[3];

            EvenNumbers2[0] = 0; //EvenNumbers2[0] this [0] is called integral indices.
            EvenNumbers2[1] = 2;

            Console.WriteLine(EvenNumbers[20]); //IndexOutofRangeException: Index was out the bounds of the array.
                                                //IndexOutOfRangeException: The exception that is thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds.
                                                //The IndexOutOfRangeException is a Runtime Exception thrown only at runtime.


            //Advantages: Arrays are strongly typed.
            //Disadvantages: Arrays cannot grows in size once initialized.
            //Have to rely on integral indices to store or retrive items from the array.

        }

        static void Main1()
        {
            Console.WriteLine("Welcome to C# Training 1!");
        }
    }
}
