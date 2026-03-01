using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathe b = new Breathe();
                b.RunBreathe();
            }
            else if (choice == "2")
            {
                Reflect r = new Reflect();
                r.RunReflect();
            }
            else if (choice == "3")
            {
                ListActivity l = new ListActivity();
                l.RunList();
            }
        }
    }
}