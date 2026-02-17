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
        for (int i = 0; i < numbers.Count; i++) // .count 를 써서 리스트 안에 요소의 개수를 알아낸다.
        {
            sum+=numbers[i]; // numbers 라는 리스트에 i번째 있는 요소를 합친다.
        }
        double avg = (double)sum / numbers.Count;
        int highestNumber = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (highestNumber < numbers[i])
            {
                highestNumber = numbers[i]; // numbers 리스트에 있는 i 번째 요소를 비교한뒤, 숫자가 최댓값보다 크다면, i번째 숫자가 최댓값으로 변경을 한다.
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