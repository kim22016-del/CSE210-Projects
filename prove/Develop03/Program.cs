using System;

class Program
{
    static void Main(string[] args)
    {
        Reference rel = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(rel, text);

        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            
            string input = Console.ReadLine();

            if (input.ToLower() == "quit") 
                break;

            if (scripture.ALLHidden())
                break;

            scripture.HideRandomWords();
        }
    }
}