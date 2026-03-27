using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>(); //Added a scripture library with random selection

        library.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        library.Add(new Scripture(new Reference("1 Nephi", 3, 7, 7), "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        library.Add(new Scripture(new Reference("2 Nephi", 2, 25, 25), "Adam fell that men might be; and men are, that they might have joy."));
        library.Add(new Scripture(new Reference("2 Nephi", 31, 20, 20), "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life."));
        library.Add(new Scripture(new Reference("Alma", 37, 35, 35), "O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God."));
        library.Add(new Scripture(new Reference("Moroni", 10, 4, 4), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."));

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        while (true)
        {
            Console.Clear();

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