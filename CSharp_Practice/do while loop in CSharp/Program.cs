using System;

namespace do_while_loop_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //C# Tutorial - do while loop in c#

            //Example - 1 

            string userChoise = "";
            //string userChoise = string.Empty;

            do
            {
            Console.WriteLine("Please enter your target?");
            int target = int.Parse(Console.ReadLine());
            int start = 0;

            while (start <= target)
            {
                Console.Write("{0} ", start);
                start = start + 2;
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

        }
    }
}
