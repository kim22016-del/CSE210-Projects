using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAssignment = new Assignment("Samuel Benett", "Multiplication");
        string answer = newAssignment.GetSummary();

        MathAssignment newMathAssignment = new MathAssignment("Roberto Rodriguez","Fractions","Section 7.3","Problems 8-19");
        string answer2 = newMathAssignment.GetHomeworkList();

        WritingAssignment newWritingAssignment = new WritingAssignment("Mary Waters","European Hisory", "The Causes of World War II");
        string answer3 = newWritingAssignment.GetWritingInformation();

        Console.WriteLine(answer);
        Console.WriteLine(newMathAssignment.GetSummary());
        Console.WriteLine(answer2);
        Console.WriteLine(newWritingAssignment.GetSummary());
        Console.WriteLine(answer3);
    }
}