using System;

namespace Comments_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Tutorial - Comments in C#

            //Single Line Comments

            /* Multi line Comments */

            ///XML Documentation Comments

            //Keyboard Shortcut: Ctrl+K, Ctrl+C and Ctrl+K, Ctrl+U

            string City = "London";

            //if city is london

            if(City == "London")
            {
                Console.WriteLine("London is beautiful");
            }

            SampleClass sampleClass = new SampleClass();

        }
    }

    /// <summary>
    /// This is a sample class and a sample document
    /// </summary>
    public class SampleClass
    {

    }

}
