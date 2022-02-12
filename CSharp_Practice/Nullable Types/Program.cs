using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Tutorial - Nullable Types

            //string name = null; Reference Type - Default value of reference type is null, all reference type are nullable

            //int i = null; Value Type -Default value of value type is some form of zero (non-nullable variable), by default value type are not nullable

            //int? j = null;  nullable variable, value type can be nullable by using ? mark after variable type

            //bool? a = null; nullable variable

            //Example 1

            bool? AreYouMajor = null;

            if (AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (AreYouMajor == false)
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

            if (TicketOnSale == null)
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
    }
}
