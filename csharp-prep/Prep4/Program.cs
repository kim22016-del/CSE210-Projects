using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number;
        do
        {
            Console.Write("Enter number ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum+=numbers[i];
        }
        double avg = (double)sum / numbers.Count;
        int highestNumber = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (highestNumber < numbers[i])
            {
                highestNumber = numbers[i];
            }
        }
        double smallestNumber = highestNumber;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > 0)
            {
                if (smallestNumber > numbers[i])
                {
                    smallestNumber = numbers[i];
                }
            }
        }
        List<int> sortedNumbers = numbers.OrderBy(n => n).ToList();

        Console.WriteLine($"the sum is {sum}");
        Console.WriteLine($"the average is {avg}");
        Console.WriteLine($"The largest number is: {highestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        Console.WriteLine("The sorted list is:");
        foreach (int num in sortedNumbers)
        {
            Console.WriteLine(num);
        }
    }   
} 