namespace ConsoleApp {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            String item = "";

            int qty = (item == "car") ? 1 : 2;

            var abc = Math.Round(123.56m);
            Console.WriteLine(abc);
            var def = Math.Ceiling(123.56m);
            Console.WriteLine(def);
            Console.WriteLine(def.GetType().ToString());

            int x = 20;
            int y = x++;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}.");
            Console.WriteLine("What's your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);

        }
    }
}
