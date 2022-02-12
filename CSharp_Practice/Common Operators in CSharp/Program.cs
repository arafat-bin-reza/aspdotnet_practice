using System;

namespace Common_Operators_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Tutorial - Common Operators in c#

            int a2 = 10;
            int b2 = 2;
            int c2 = 0;

            bool number10 = (a2 == 10) ? true : false; //Ternary Operator

            Console.WriteLine("Number 10 is {0}", number10);


            if (a2 == 10 && b2 == 2)
            {
                c2 = a2 / b2;
                Console.WriteLine(c2);
            }
        }
    }
}
