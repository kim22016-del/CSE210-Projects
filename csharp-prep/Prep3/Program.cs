using System;
using System.Collections.Generic;
using System.Drawing;

class Program
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessNumber;
        string question = "yes";
        while(question == "yes")
        {
            do
            {
                Console.Write("What is your guess?");
                guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            } while (guessNumber != magicNumber);

        Console.WriteLine("You guessed it!");
        Console.Write("do you want to play again?");
        question = Console.ReadLine();
        }
    }
}