namespace GuessingGame {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Guess the Number Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100. Try to guess it!\n");

            string choice = "y";
            while (choice == "y" || choice == "y") {
                int count = 0;
                int guess = 0;
                int theNumber = getRandomNumber();
                Console.WriteLine("debug: "+theNumber+"\n");
                while (guess != theNumber) {
                    guess = getGuess();
                    count++;
                    int diff = guess - theNumber;
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (diff < -10) {
                        Console.WriteLine("Way too low!");
                    }
                    else if (diff < 0) {
                        Console.WriteLine("Too low!");
                    }
                    else if (diff > 10) {
                        Console.WriteLine("Way too high!");
                    }
                    else if (diff > 0) {
                        Console.WriteLine("Too high!");
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You win!");   
                        Console.WriteLine("You guessed the number in "+count+" tries!");
                        displayWinMessage(count);
                    }
                    Console.ResetColor();
                }
                Console.Write("Try again? ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("bye");
        }

        static void displayWinMessage(int count) {
            if (count <= 3) {
                Console.WriteLine("Great work! You are a mathematical wizard.");
            }
            else if (count <= 7) {
                Console.WriteLine("Not too bad! You've got some potential.");
            }
            else {
                Console.WriteLine("What took you so long? Maybe you should take some lessons.");
            }
        }

        static int getRandomNumber() {
            Random random = new Random();
            int randNbr = random.Next(1, 100);
            return randNbr;
        }

        static int getGuess() {
            int guess = 0;
            Boolean success = false;
            while (!success) {
                Console.Write("Guess the number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < 1 || guess > 100) {
                    Console.WriteLine("Invalid guess... must be between 1 and 100.");
                }
                else {
                    success = true;
                }
            }
            return guess;
        }
    }
}
