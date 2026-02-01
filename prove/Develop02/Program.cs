using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        Prompt prompt = new Prompt();
        int repeat = 1;

        while (repeat == 1)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                AddEntry(journal, prompt);
            }
            else if (choice == "2")
            {
                ShowEntries(journal);
            }
            else if (choice == "3")
            {
                SaveEntries(journal);
            }
            else if (choice == "4")
            {
                LoadEntries(journal);
            }
            else if (choice == "5")
            {
                repeat = 0;
            }
            else
            {
                Console.WriteLine("Wrong choice. Try again.");
            }
        }
    }

    static void AddEntry(Journal journal, Prompt prompt)
    {
        Console.WriteLine("Do you have a enough time to write journal? (y/n)"); //I added check-in if user do not have enough time to write a journal.
        string timeQuestionChoice = Console.ReadLine();                         //It helps user keep recording something.
        if (timeQuestionChoice == "n")
        {
            Console.Write("Did you smile today? (yes/no): ");
            string smile = Console.ReadLine();

            Console.Write("Did you pray today? (yes/no)");
            string pray = Console.ReadLine();

            string response = $"Smiled={smile}, pray={pray}";
            string date = DateTime.Now.ToShortDateString();
            Entry entry = new Entry("Quick Check-In", response, date);
            journal.AddEntry(entry);

        }

        else
        {
            string question = prompt.GetRandomPrompt();
            Console.WriteLine(question);
            string response = Console.ReadLine();
            string date = DateTime.Now.ToShortDateString();

            Entry entry = new Entry(question, response, date);
            journal.AddEntry(entry);
            Console.WriteLine("added!");
        }

    }

    static void ShowEntries(Journal journal)
    {
        var entries = journal.GetEntries();
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        Console.WriteLine("\nYour Journal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    static void SaveEntries(Journal journal)
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("saved!");
    }

    static void LoadEntries(Journal journal)
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("loaded!");
    }
}
