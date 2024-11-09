using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        do
        {
            Random randomGenerator = new Random();
            int magic_number = randomGenerator.Next(1, 101);
            int guess = 0;
            int attempts = 1;


            while (guess != magic_number)
            {
                Console.Write("What is your guess?: ");
                guess = int.Parse(Console.ReadLine());


                if (guess < magic_number)
                {
                    attempts++;
                    Console.WriteLine("Higher");
                }

                else if (guess > magic_number)
                {
                    attempts++;
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine($"Correct! \nNumber of guesses: {attempts}");
                }
            }

            Console.Write("Would you like to play again? (yes/no): ");
            response = Console.ReadLine();
        } while (response == "yes");

        Console.WriteLine("\nThank you so much for playing my game!");
    }
}