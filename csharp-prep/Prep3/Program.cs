using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = GenerateMagicNumber();

        int guess = -1;

        while (guess != magicNumber)
        {
            guess = GetUserGuess();

            EvaluateGuess(guess, magicNumber);
        }
    }

    static int GenerateMagicNumber()
    {
        Random randomGenerator = new Random();
        return randomGenerator.Next(1, 101);
    }

    static int GetUserGuess()
    {
        Console.Write("What is your guess? ");
        return int.Parse(Console.ReadLine());
    }

    static void EvaluateGuess(int guess, int magicNumber)
    {
        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}
