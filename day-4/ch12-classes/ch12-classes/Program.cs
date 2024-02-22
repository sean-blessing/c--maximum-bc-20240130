using movie_classes;

namespace ch12_classes {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Classes!");

            Movie m1 = new Movie();
            m1.Id = 1;
            m1.Title = "Star Wars Episode IV: A New Hope";
            m1.Year = 1976;
            m1.Rating = "PG-13";
            m1.Director = "George Lucas";
        }
    }
}
