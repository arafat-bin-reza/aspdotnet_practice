using System;

namespace If_statement_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Tutorial - If statement in C#

            //if statement

            //Example - 1

            Console.WriteLine("Please enter a number");

            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 1)
            {
                Console.WriteLine("userNumber is one");
            }

            //Example - 2

            Console.WriteLine("Please enter a number");

            int userNumber2 = int.Parse(Console.ReadLine());

            if (userNumber2 == 1)
            {
                Console.WriteLine("userNumber is one");
            }

            if (userNumber2 == 2)
            {
                Console.WriteLine("userNumber is two");
            }

            if (userNumber2 == 3)
            {
                Console.WriteLine("userNumber is three");
            }

            if (userNumber2 != 1 && userNumber2 != 2 && userNumber2 != 3)
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }

            //if else statement

            //Example - 3

            Console.WriteLine("Please enter a number");

            int userNumber3 = int.Parse(Console.ReadLine());

            if (userNumber3 == 1)
            {
                Console.WriteLine("userNumber is one");
            }

            else if (userNumber3 == 2)
            {
                Console.WriteLine("userNumber is two");
            }

            else if (userNumber3 == 3)
            {
                Console.WriteLine("userNumber is three");
            }

            else
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }


            //Difference between && and &

            /* && and & work same way, both use as and in conditional statemet. 
             * Only difference between && and & is && do not check all conditions, if one of the condition is false.
             * it escape all other condition after that to save execusion time and it is performance efficient.
             * & check all conditions, Even one of the condition is false.
             */

            //Example - 4

            Console.WriteLine("Please enter a number");

            int userNumber4 = int.Parse(Console.ReadLine());

            if (userNumber4 == 10 && userNumber4 == 20)
            {
                Console.WriteLine("Your Number is 10 and 20");
            }
            else
            {
                Console.WriteLine("Your Number is not 10 and 20");
            }


            //Example - 5

            Console.WriteLine("Please enter a number");

            int userNumber5 = int.Parse(Console.ReadLine());

            if (userNumber5 == 10 & userNumber5 == 20)
            {
                Console.WriteLine("Your Number is 10 and 20");
            }
            else
            {
                Console.WriteLine("Your Number is not 10 and 20");
            }


            //Difference between || and |

            /* || and | work same way, both use as or in conditional statemet. 
             * Only difference between || and | is || do not check all conditions, if one of the condition is true.
             * it escape all other condition after that to save execusion time and it is performance efficient.
             * | check all conditions, Even one of the condition is true.
             */


            //Example - 6

            Console.WriteLine("Please enter a number");

            int userNumber6 = int.Parse(Console.ReadLine());

            if (userNumber6 == 10 || userNumber6 == 20)
            {
                Console.WriteLine("Your Number is 10 or 20");
            }
            else
            {
                Console.WriteLine("Your Number is not 10 or 20");
            }


            //Example - 7

            Console.WriteLine("Please enter a number");

            int userNumber7 = int.Parse(Console.ReadLine());

            if (userNumber7 == 10 | userNumber7 == 20)
            {
                Console.WriteLine("Your Number is 10 or 20");
            }
            else
            {
                Console.WriteLine("Your Number is not 10 or 20");
            }

        }
    }
}
