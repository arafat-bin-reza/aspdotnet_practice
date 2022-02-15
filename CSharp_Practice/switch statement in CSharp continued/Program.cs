using System;

namespace switch_statement_in_CSharp_continued
{
    class Program
    {
        static void Main(string[] args)
        {

            //C# Tutorial - switch statement in c# continued

            int Totalcoffeecost = 0;

            start:
            Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
            int userChoice = int.Parse(Console.ReadLine());

            switch(userChoice)
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
             
            switch(userDecision.ToUpper())
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
        }
    }
}
