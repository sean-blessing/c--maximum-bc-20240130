using System.Collections;
using System.Diagnostics;

namespace LabArrayList {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Lists App!");

            string[] daysOfWeek = { "Sunday", "Monday", "Second Monday", "Hump Day",
                                    "First Friday", "Second Friday", "Saturday"};

            for (int i = 0; i < daysOfWeek.Length; i++) {
                Console.WriteLine(daysOfWeek[i]);
            }

            DateTime today = DateTime.Now;
            Console.WriteLine("Today (dow): "+today.DayOfWeek);
            Console.WriteLine("Today (dow#): " + (int)today.DayOfWeek);

            ArrayList dow = new ArrayList{"Sunday", "Monday", "Tuesday", "Wednesday",
                                                  "Thursday", "Friday", "Saturday", "Sunday"};
            foreach (string day in dow) { 
                Console.WriteLine($"{day}");
            }


            Console.WriteLine("bye");
        }
    }
}
