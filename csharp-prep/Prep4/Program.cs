using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");


        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        if (numbers.Count > 0 )
        {
            int sum = 0;
            int max = numbers[0];

            foreach (int num in numbers)
            {
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }

            float average = (float)sum / numbers.Count;

            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);
            Console.WriteLine("The largest number is: " + max);
        }

        else
        {
            Console.WriteLine("Enter numbers (No number entered)");
        }
    }
}