using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // first, we need to create an instance of a calendar program
            Calendar myCalendar = new Calendar();

            // next, we ask the user what month it is
            Console.WriteLine("Hey there! What month is it?");

            // capture their response from the console
            string response = Console.ReadLine();

            // declare a variable for the month
            int month;

            // convert the string response into an integer.
            if (Int32.TryParse(response, out month))
            {
                // if we got here, we got a valid integer from the user

                if (myCalendar.IsItSummer(month))
                {
                    Console.WriteLine("Surf's up! It's summer time!");
                }
                else
                {
                    Console.WriteLine("That's lame. I can't wait for summer.");
                }
            }
            else
            {
                
                Console.WriteLine("Sorry, I don't understand.");
            }
        }
    }
    class Calendar
    {
        List<int> SummerMonths = new List<int>() {6,7,8};

        // We need to make this public so the program can call this method
        public bool IsItSummer(int month)
        {
            foreach(int summerMonth in SummerMonths) 
            {
                if (summerMonth == month)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
