using System;

namespace Reading_and_writing_to_a_console
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
