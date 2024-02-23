namespace ProductInterface {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Product Manager!");

            Book b1 = new Book("java", "Murach's Java Programming", 59.5m, "Mike Murach");
            Book b2 = new Book("andr", "Murach's Android Programming", 62.5m, "Joel Murach");
            Book b3 = new Book("net", "Murach's .Net Programming", 61.5m, "Mike Murach");

            Software s1 = new Software("eclp", "Eclipse", 0, "v10");
            Software s2 = new Software("vsc", "Microsoft Visual Studio Code", 0, "v1.5");

            Product[] products = {b1, b2, b3, s1, s2};

            foreach (Product p in products) {
                Console.WriteLine(p.print());
            }

            Console.WriteLine("bye");
        }
    }
}
