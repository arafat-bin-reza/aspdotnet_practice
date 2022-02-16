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


            //C# Tutorial - Comments in C#

            //Single Line Comments

            /* Multi line Comments */

            ///XML Documentation Comments

            //Keyboard Shortcut: Ctrl+K, Ctrl+C and Ctrl+K, Ctrl+U

            string City = "London";

            //if city is london

            if (City == "London")
            {
                Console.WriteLine("London is beautiful");
            }

            SampleClass sampleClass = new SampleClass();


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


            //C# Tutorial - switch statement in C#

            //Example - 1

            Console.WriteLine("Please enter a number");

            int userNumber8 = int.Parse(Console.ReadLine());

            switch (userNumber8)
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

            int userNumber9 = int.Parse(Console.ReadLine());

            switch (userNumber9)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("userNumber is {0}", userNumber9); //joining multiple case statements
                    break;
                default:
                    Console.WriteLine("userNumber is not 10, 20 & 30");
                    break;

            }

            //C# Tutorial - switch statement in c# continued

            int Totalcoffeecost = 0;

             start:
            Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Totalcoffeecost += 1;
                    break;
                case 2:
                    Totalcoffeecost += 2;
                    break;
                case 3:
                    Totalcoffeecost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid, Please try again...", userChoice);
                    goto start;
            }

            decide:
            Console.WriteLine("Do you want to buy another coffee - Yes or No?");
            string userDecision = Console.ReadLine();

            switch (userDecision.ToUpper())
            {
                case "YES":
                    goto start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid, Please try again...", userDecision);
                    goto decide;
            }

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", Totalcoffeecost);


            //C# Tutorial - while loop in c#

            //Example - 1 

            Console.WriteLine("Please enter your target?");
            int target = int.Parse(Console.ReadLine());
            int start = 0;

            while (start <= target)
            {
                Console.Write("{0} ", start);
                start = start + 2;
            }

            Console.WriteLine();

            //Example - 2 - Never ending loop

            Console.WriteLine("Please enter your target?");
            int target2 = int.Parse(Console.ReadLine());
            int start2 = 0;

            while (start2 <= target2)
            {
                Console.Write("{0} ", start2);
                //start2 = start2 + 2; //do not forget to add increament in while loop, otherwise it might become a Never ending loop 
            }


            //C# Tutorial - do while loop in c#

            //Example - 1 

            string userChoise = "";
            //string userChoise = string.Empty;

            do
            {
                Console.WriteLine("Please enter your target?");
                int target3 = int.Parse(Console.ReadLine());
                int start3 = 0;

                while (start3 <= target3)
                {
                    Console.Write("{0} ", start3);
                    start3 = start3 + 2;
                }

                Console.WriteLine();

                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No");
                    userChoise = Console.ReadLine().ToUpper();

                    if (userChoise != "YES" && userChoise != "NO")
                    {
                        Console.WriteLine("Invalid Choice, please enter Yes or No");
                    }
                } while (userChoise != "YES" && userChoise != "NO");
            } while (userChoise == "YES");


            //Example - 2

            int Totalcoffeecost2 = 0;
            int userChoice2 = 0;
            string userDecision2 = "";

            do
            {
                do
                {
                    Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
                    userChoice2 = int.Parse(Console.ReadLine());

                    switch (userChoice2)
                    {
                        case 1:
                            Totalcoffeecost2 += 1;
                            break;
                        case 2:
                            Totalcoffeecost2 += 2;
                            break;
                        case 3:
                            Totalcoffeecost2 += 3;
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid, Please try again...", userChoice2);
                            break;
                    }
                } while (userChoice2 != 1 && userChoice2 != 2 & userChoice2 != 3);



                do
                {
                    Console.WriteLine("Do you want to buy another coffee - Yes or No?");
                    userDecision2 = Console.ReadLine().ToUpper();

                    switch (userDecision2)
                    {
                        case "YES":
                            break;
                        case "NO":
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid, Please try again...", userDecision2);
                            break;
                    }

                } while (userDecision2 != "YES" && userDecision2 != "NO");
            } while (userDecision2 == "YES");

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", Totalcoffeecost2);


            //C# Tutorial - for and foreach loops in c#

            //Example - 1 (for loop)

            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            for (int iiii = 0; iiii < numbers.Length; iiii++)
            {
                Console.WriteLine(numbers[iiii]);
            }

            //Example - 2 (for loop)

            int[] numbers2 = new int[3];
            numbers2[0] = 101;
            numbers2[1] = 102;
            numbers2[2] = 103;

            for (int iii = 0; iii <= numbers2.Length; iii++) // we have only 3 element in array, but condition is looking for 4th element
            {
                Console.WriteLine(numbers[iii]); //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.', This is a runtime exception
            }

            //Example - 3 (foreach loop)

            int[] numbers3 = new int[3];
            numbers3[0] = 101;
            numbers3[1] = 102;
            numbers3[2] = 103;

            foreach (var k in numbers3)
            {
                Console.WriteLine(k);
            }

            //Example - 4 (for loop - using break statement)

            for (int ii = 0; ii <= 20; ii++)
            {
                Console.WriteLine(ii);
                if (ii == 10)
                {
                    break;
                }
            }

            //Example - 5 (for loop - even numbers)

            for (int i5 = 0; i5 <= 20; i5 = i5 + 2)
            {
                Console.WriteLine(i5);
            }

            //Example - 6 (for loop - even numbers using continue statement)

            for (int i6 = 0; i6 <= 20; i++)
            {
                if (i6 % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i6);
            }


        }

        static void Main1()
        {
            Console.WriteLine("Welcome to C# Training 1!");
        }
    }

    /// <summary>
    /// This is a sample class and a sample document
    /// </summary>
    public class SampleClass
    {

    }

}
