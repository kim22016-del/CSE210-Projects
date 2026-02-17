using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Prompt thePrompt = new Prompt();
        Console.WriteLine("Welcome the the journal Program!");
        int userNum;
        do
        {

            Console.WriteLine("Please select one tof the following choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do?: ");
            userNum = int.Parse(Console.ReadLine());
            if (userNum == 1 )
            {

                Console.Write("Do you have a enough time to write journal? (y/n): "); //I added check-in if user do not have enough time to write a journal.
                string quickJournal = Console.ReadLine().ToLower();

                string response = "";
                string promptToSave = "";

                if (quickJournal == "y")
                {
                    promptToSave = thePrompt.GetRandomPrompt();
                    Console.WriteLine(promptToSave);
                    response = Console.ReadLine();

                }
                else if (quickJournal == "n")
                {
                    Console.WriteLine("Quick Check-in mode: ");

                    Console.Write("Did you smile today? (y/n): ");
                    string smile = Console.ReadLine();

                    Console.Write("Did you pray today? (y/n): ");
                    string pray = Console.ReadLine();

                    response = $"[Smiled: {smile}, Prated: {pray}]";
                }
                else
                {
                    Console.WriteLine("Sorry Enter again");
                }
                if (response != "")
                {
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = promptToSave;
                    newEntry._entryText = response;

                    theJournal.AddEntry(newEntry);
                }
                


            }
            else if (userNum == 2)
            {
                theJournal.DisplayAll();
            }
            else if (userNum == 3)
            {
                Console.Write("Please enter your file name: ");
                string fileName = Console.ReadLine();

                theJournal.LoadFromFile(fileName);
                Console.WriteLine("file loaded");

                theJournal.DisplayAll();
            }
            else if (userNum == 4)
            {
                Console.WriteLine("Please create file name: ");
                string fileName = Console.ReadLine();

                theJournal.SaveToFile(fileName);
            }
        } while (userNum != 5);

        Console.WriteLine("Good Bye!");

    }
}