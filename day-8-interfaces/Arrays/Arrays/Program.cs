namespace Arrays {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Arrays!");
            string s1 = "Hello";
            string s2 = "World";

            string[] words;
            words = new string[4];

            words[0] = s1;
            words[1] = s2;
            words[2] = "Again!";
            words[3] = "Fred";
            //words[4] = "Out of bounds"; 

            Console.WriteLine($"the third item is {words[2]}");

            int[] myInts = new int[10];
            myInts[5] = 1200;
            myInts[8] = 5;
            myInts[9] = 99;

            for (int i = 0; i < myInts.Length; i++) {
                Console.WriteLine(myInts[i]);
            }

            Customer[] custs = new Customer[3];
            custs[0] = new Customer("George McFly", "george@b2f.com", "555-444-3333");
            custs[1] = new Customer("Marty McFly", "marty@b2f.com", "555-444-1234");
            custs[2] = new Customer("Emmett Brown", "flux-capacitor@b2f.com", "555-444-3333");

            Console.WriteLine(custs);
            
            foreach (Customer cust in custs) {
                Console.WriteLine(cust);
            }



            Console.WriteLine("bye");
        }
    }
}
