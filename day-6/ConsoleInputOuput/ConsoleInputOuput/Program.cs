namespace ConsoleInputOuput {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Console IO!");

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your favorite number: ");
            int nbr = Convert.ToInt32(Console.ReadLine());

            //decimal price = Convert.ToDecimal(Console.ReadLine());
            //double interest = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hello {name}, your favorite # is {nbr}.");


            Console.WriteLine("Bye!");
        }
    }
}
