using System.Globalization;

namespace Exceptions {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Exceptions!");
            Boolean success = false;

            DateTime dateTime = DateTime.Now;

            // Use Exception Handling to validate a date
            while (!success) { 
                Console.WriteLine("Let's enter a date.");
                int year = getInt("Enter Year: ");

                int month = getInt("Enter Month Number (1 - 12): ", 1, 12);
                //Console.WriteLine($"Month: " + DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(monthNbr));

                // first attempt - hardcoding 31 as max
                //int day = getInt($"Enter Day Number (1 - 31): ", 1, 31);

                // second attempt - dynamically set max based on year and month
                int maxDayForMonthYear = DateTime.DaysInMonth(year, month);
                int day = getInt($"Enter Day Number (1 - {maxDayForMonthYear}): ", 1, maxDayForMonthYear);
                //Console.WriteLine($"Day of Week: " + Enum.GetName(typeof(DayOfWeek), (dowNbr-1)));


                try {
                    dateTime = new DateTime(year, month, day);
                    Console.WriteLine($"Date is: {dateTime.ToShortDateString()}");
                    success = true;
                }
                catch (System.ArgumentOutOfRangeException saoore) {
                    Console.WriteLine(saoore.Message);
                    Console.WriteLine($"Year ({year}) / Month ({month}) / Day ({day})");
                    Console.WriteLine("Try again.");
                    success = false;
                }
            }
            Console.WriteLine("bye");
        }

        // Use data validation to validate a whole number within a range
        private static int getInt(string prompt, int min, int max) {
            int monthNbr = 0;
            Boolean success = false;

            while (!success) {
                monthNbr = getInt(prompt);
                if (monthNbr < min) {
                    Console.WriteLine($"Input must be greater than, or equal to, {min}.");
                    Console.WriteLine("Please try again.\n");
                    success = false;
                }
                else if (monthNbr > max) {
                    Console.WriteLine($"Input must be less than, or equal to, {max}.");
                    Console.WriteLine("Please try again.\n");
                    success = false;
                }
                else { 
                    success = true;
                }
            }

            return monthNbr;
        }

        // Use exception handling to get a valid whole number
        private static int getInt(string prompt) {
            int nbr = 0;
            Boolean success = false;

            while (!success) {
                try {
                    Console.Write(prompt);
                    nbr = Int32.Parse(Console.ReadLine());
                    success = true;
                }
                catch (System.FormatException sfe) {
                    Console.WriteLine(sfe.Message);
                    Console.WriteLine("Please enter a whole number.\n");
                    success = false;
                }
            }
            return nbr;
        }
    }
}
