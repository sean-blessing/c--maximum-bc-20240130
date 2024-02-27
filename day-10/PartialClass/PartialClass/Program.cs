namespace PartialClass {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            BankAccount ba1 = new BankAccount();
            // from BankAccount.cs
            ba1.AcctID = 1;
            // from BankAccountDataAccess.cs
            ba1.SomeBankAccountMethod();
        }
    }
}
