using MikesFinFun;

namespace Ch14Scope {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Scope!");

            BankFunctions bf1 = new BankFunctions();
            decimal x = bf1.Alpha(123);
        }
    }
}
