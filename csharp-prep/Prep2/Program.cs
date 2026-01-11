using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your percentage of grade. ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string score = "none";

        if (number > 90 || number == 90)
        {
            score = "A";
        }
        else if (number > 80 || number == 80)
        {
            score = "B";
        }
        else if (number > 70 || number == 70)
        {
            score = "C";
        }
        else if (number > 60 || number == 60)
        {
            score = "D";
        }
        else
        {
            score = "F";
        }
        Console.WriteLine($"Grade: {score}");

        if (number > 60 || number == 60)
        {
            Console.WriteLine("Congratulation! you passed the test!");
        }
        else
        {
            Console.WriteLine("sorry you failed the test.");
        }
    }
}