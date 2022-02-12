using System;

namespace String_type_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
