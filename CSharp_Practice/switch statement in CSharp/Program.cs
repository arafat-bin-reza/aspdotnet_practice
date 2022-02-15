using System;

namespace switch_statement_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Tutorial - switch statement in C#

            //Example - 1

            Console.WriteLine("Please enter a number");

            int userNumber4 = int.Parse(Console.ReadLine());

            switch (userNumber4)
            {
                case 10:
                    Console.WriteLine("userNumber is 10");
                    break;
                case 20:
                    Console.WriteLine("userNumber is 20");
                    break;
                case 30:
                    Console.WriteLine("userNumber is 30");
                    break;
                default:
                    Console.WriteLine("userNumber is not 10, 20 & 30");
                    break;

            }

            //Example - 2

            Console.WriteLine("Please enter a number");

            int userNumber5 = int.Parse(Console.ReadLine());

            switch (userNumber5)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("userNumber is {0}", userNumber5); //joining multiple case statements
                    break;
                default:
                    Console.WriteLine("userNumber is not 10, 20 & 30");
                    break;

            }


        //Note: Case statements, with no code in-between,
        //creates a single case for multiple values.
        //A case without any code will automatically fall through to the next case.
        //In this example, case 10 and case 20 will fall through and execute code for case 30.

        }
    }
}
