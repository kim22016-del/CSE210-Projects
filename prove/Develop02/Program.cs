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
                string randomPrompt = thePrompt.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                string response = Console.ReadLine();
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = randomPrompt;
                newEntry._entryText = response;

                theJournal.AddEntry(newEntry);
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