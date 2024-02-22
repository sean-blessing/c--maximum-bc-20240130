namespace Lab061AInheritance {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Banking Accounts App!");

            //BankingAccount ba = new BankingAccount(100, "Susan", "Jones", "123 Test St.", "Columbus", "OH", "43201", 1234.56m);
            //ba.Status = "Active";

            //Console.WriteLine(ba);

            CheckingAccount ck1 = new CheckingAccount(101, "Bob", "Smith", "1156 Runaway St.", "Columbus", "OH", "43201");
            Console.WriteLine(ck1);

            SavingsAccount sa = new SavingsAccount(201, "Norish", "Patel", "7788 Toolbox Way", "Columbus", "OH", "43201");
            Console.WriteLine(sa);

            BusinessCheckingAccount bsa = new BusinessCheckingAccount(301, "Amy", "Adams", "6473 Lovely Ave.", "Columbus", "OH", "43201", "Temp Company", "123-45-0943");
            Console.WriteLine(bsa);

            Console.WriteLine($"Balance for ck1: {ck1.Balance}");
            Console.WriteLine("Depositing 1000");
            ck1.MakeDeposit(1000);
            Console.WriteLine($"Balance for ck1: {ck1.Balance}");
            Console.WriteLine("Depositing 500");
            ck1.MakeDeposit(500);
            Console.WriteLine($"Balance for ck1: {ck1.Balance}");
            Console.WriteLine("Withdrawing 300");
            ck1.MakeWithdrawal(300);
            Console.WriteLine($"Balance for ck1: {ck1.Balance}");
            Console.WriteLine("bye");
        }
    }
}
