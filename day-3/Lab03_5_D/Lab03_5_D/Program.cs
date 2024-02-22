namespace Lab03_5_D {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Lab 03-5-D!");

            Console.WriteLine("EvenNumbers(4,13) returns: " + EvenNumbers(4, 13));
            Console.WriteLine("EvenNumbers(3,10) returns: " + EvenNumbers(3, 10));
            Console.WriteLine("EvenNumbers(8,21) returns: " + EvenNumbers(8, 21));

            Console.WriteLine();



        }
        static string EvenNumbers(int minNumber, int maxNumber) {
            string str = "";
            int diff = minNumber - maxNumber;

            if (diff > 0) {
                Console.WriteLine($"Error: Min number ({minNumber}) should be less than max number ({maxNumber}).");
                int saveNumber = minNumber;
                minNumber = maxNumber;
                maxNumber = saveNumber;
            }
            else if (diff == 0) {
                Console.WriteLine("Min and Max are the same. No output.");
            }
            else { 
                for (int i = minNumber; i <= maxNumber; i++) {
                    if (i % 2 == 0) {
                        str += i;
                        if ((i - maxNumber) < -1) {
                            str += ", ";
                        }
                    }
                }
            }
            return str;
        }
    }
}
