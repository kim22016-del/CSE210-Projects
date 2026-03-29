using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# in 100 Seconds", "Fireship", 226);
        video1.AddComment(new Comment("John", "This was really helpful!"));
        video1.AddComment(new Comment("Emily", "Clear explanation, thanks."));
        video1.AddComment(new Comment("Mike", "Looking forward to the python."));

        Video video2 = new Video("C in 100 Seconds", "Fireship", 224);
        video2.AddComment(new Comment("Alice", "Great explanation of C!"));
        video2.AddComment(new Comment("Bob", "I finally understand classes now."));

        Video video3 = new Video("100+ Linux Things you Need to Know", "Fireship", 1222);
        video3.AddComment(new Comment("Minkyu", "Thanks for the video!"));
        video3.AddComment(new Comment("Bob", "bro can you not make a 12 minute video that sums up a year of college. thanks"));
        video3.AddComment(new Comment("User", "I am new to Linux ,and my brain feels fried and rewired at the same time after watching this."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video vid in videos)
        {
            vid.Display();
        }
    }
}