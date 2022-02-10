using System;

namespace CSharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //C# Tutorial - Introduction

            Console.WriteLine("Welcome to C# Training!");
            Main1();


            //C# Tutorial - Reading and writing to a console

            //Example 1

            Console.WriteLine("Please enter your name");

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
            string c = "D:\\Web Development\\aspdotnet_practice";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //Verbatim Literal

            string d = @"D:\Web Development\aspdotnet_practice";
            Console.WriteLine(d);


            //C# Tutorial - Common Operators in c#

            int a2 = 10;
            int b2 = 2;
            int c2 = 0;

            bool number10 = (a2 == 10) ? true : false;

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

        }

        static void Main1()
        {
            Console.WriteLine("Welcome to C# Training 1!");
        }
    }
}
