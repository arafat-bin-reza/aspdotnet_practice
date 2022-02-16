using System;

namespace do_while_loop_in_CSharp_continued
{
    class Program
    {
        static void Main(string[] args)
        {
            int Totalcoffeecost = 0;
            int userChoice = 0;
            string userDecision = "";

            do
            {
                do
                {
                    Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
                    userChoice = int.Parse(Console.ReadLine());

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
                            break;
                    }
                } while (userChoice != 1 && userChoice != 2 & userChoice != 3);



                do
                {
                    Console.WriteLine("Do you want to buy another coffee - Yes or No?");
                    userDecision = Console.ReadLine().ToUpper();

                    switch (userDecision)
                    {
                        case "YES":
                            break;
                        case "NO":
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid, Please try again...", userDecision);
                            break;
                    }

                } while (userDecision != "YES" && userDecision != "NO");
            } while (userDecision == "YES");

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", Totalcoffeecost);
        }
    }
}
