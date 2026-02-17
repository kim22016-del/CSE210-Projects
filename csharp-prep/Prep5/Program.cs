using System;
using System.Diagnostics;

class Program // 여러개의 함수가 서로 상호작용하도록 코드를 설계함.
{
    static void DisplayWelcome()
    {
        Console.Write("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static void PromtUserBirthYear(out int userbirthYear)
    {
        Console.Write("Please enter the year you were born: ");
        userbirthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;
    }
    static void DisplayResult(string userName, int userbirthYear, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
        Console.WriteLine($"{userName}, you will turn {2026 - userbirthYear} this year");
    }
    static void Main()
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        PromtUserBirthYear(out int userbirthYear);
        int squared = SquareNumber(number);
        DisplayResult(name, userbirthYear, squared);
    }

}