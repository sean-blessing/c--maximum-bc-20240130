namespace DateTimeProj {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Date Time!");

            DateTime d1 = DateTime.Now;

            DateTime startDate = new DateTime(2023, 01, 30);

            DateTime endDate = DateTime.Parse("2023/02/01");
            DateTime endDate2 = DateTime.Parse("2/1/23");
            DateTime christmas = new DateTime(2024, 12, 25);
            Console.WriteLine(startDate);
            Console.WriteLine(endDate);
            Console.WriteLine(endDate2);
            Console.WriteLine($"Right Now: {d1}");
            Console.WriteLine($"Current Month: {d1.Month}");
            Console.WriteLine($"Current Day: {d1.Day}");
            Console.WriteLine($"Current Day of Week: {d1.DayOfWeek}");
            Console.WriteLine($"Current Year: {d1.Year}");

            Console.WriteLine($"Days until Christmas: {christmas.Subtract(d1).Days}.");
        }
    }
}
