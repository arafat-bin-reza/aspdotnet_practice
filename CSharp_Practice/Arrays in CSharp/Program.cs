using System;

namespace Arrays_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Tutorial - Arrays in C#
            //Arrays: An array is a collection of similar data types.

            //Example - 1

            //Initialize and Assign Values in difference lines
            int[] EvenNumbers = new int[3];

            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;
            //EvenNumbers[3] = 6; //IndexOutofRangeException: Index was out the bounds of the array.
                                //IndexOutOfRangeException: The exception that is thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds.
                                //The IndexOutOfRangeException is a Runtime Exception thrown only at runtime.

            Console.WriteLine(EvenNumbers[2]);

            //Initialize and Assign Values in difference lines

            //Example - 2

            int[] OddNumbers = { 1, 3, 5 };

            Console.WriteLine(OddNumbers[2]);


            //Example - 3

            //Initialize and Assign Values in difference lines
            int[] EvenNumbers2 = new int[3];

            EvenNumbers2[0] = 0; //EvenNumbers2[0] this [0] is called integral indices.
            EvenNumbers2[1] = 2;

           //Console.WriteLine(EvenNumbers[20]); //IndexOutofRangeException: Index was out the bounds of the array.
                                                //IndexOutOfRangeException: The exception that is thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds.
                                                //The IndexOutOfRangeException is a Runtime Exception thrown only at runtime.


            //Advantages: Arrays are strongly typed.
            //Disadvantages: Arrays cannot grows in size once initialized.
            //Have to rely on integral indices to store or retrive items from the array.
        }
    }
}
