using System;

namespace for_and_foreach_loops_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Tutorial - for and foreach loops in c#

            //Example - 1 (for loop)

            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]); 
            }

            //Example - 2 (for loop)

            int[] numbers2 = new int[3];
            numbers2[0] = 101;
            numbers2[1] = 102;
            numbers2[2] = 103;

            for (int i = 0; i <= numbers2.Length; i++) // we have only 3 element in array, but condition is looking for 4th element
            {
                Console.WriteLine(numbers[i]); //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.', This is a runtime exception
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

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (i == 10)
                {
                    break;
                }
            }

            //Example - 5 (for loop - even numbers)

            for (int i = 0; i <= 20; i=i+2)
            {
                Console.WriteLine(i);
            }

            //Example - 6 (for loop - even numbers using continue statement)

            for (int i = 0; i <= 20; i++)
            {
                if (i%2==1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
