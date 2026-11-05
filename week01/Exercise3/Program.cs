using System;

Random randomGenerator = new Random();
string playAgain = "yes";

while (playAgain.Equals("yes", StringComparison.OrdinalIgnoreCase))
{
    int magicNumber = randomGenerator.Next(1, 101);
    int guessCount = 0;
    int guess;

    do
    {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine() ?? "0");
        guessCount++;

        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    } while (guess != magicNumber);

    Console.WriteLine($"You guessed {guessCount} times.");
    Console.Write("Would you like to play again? ");
    playAgain = Console.ReadLine() ?? "no";
}
