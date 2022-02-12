using System;

namespace Datatypes_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //int i4 = int.Parse(strNumber2); //FormatException: Input string was not in a correct format.
                                            //Parse method () throw an exception if it cannot parse the value
                                            //FormatException: The exception that is thrown when the format of an argument is invalid, or when a composite format string is not well formed.
                                            //An FormatException is thrown at run time, so this is a runtime exception.


            //Console.WriteLine(i4);


            //TryParse method ()

            //Example - 5

            string strNumber3 = "100TG";

            int Result = 0;

            bool IsConversionSuccessful = int.TryParse(strNumber3, out Result); //TryParse method () returns a bool indication whether it succeeded or failed

            if (IsConversionSuccessful)
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Enter a valid Number");
            }
        }
    }
}
