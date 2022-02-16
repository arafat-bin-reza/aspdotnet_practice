using System;

namespace while_loop_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
