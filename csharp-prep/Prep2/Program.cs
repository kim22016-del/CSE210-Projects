using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int intGrade = int.Parse(grade);
        string letter ="";

        if (intGrade >= 90)
        {
            letter = "A";
        }
        else if (intGrade >= 80)
        {
            letter = "B";
        }
        else if (intGrade >= 70)
        {
            letter = "C";
        }
        else if (intGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.Write($"Grade:{letter} ");
        
        if (intGrade >= 70)
        {
            Console.WriteLine("//You passed the test!");
        }
        else
        {
            Console.WriteLine("//Sorry you didn't pass the test!");
        }
    }
}