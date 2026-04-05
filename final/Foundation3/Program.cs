using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("AI Future", "Talk about AI", "2026-03-01", "10:00 AM", "STC321", "Bro Kim", 50);
        Reception reception = new Reception("Networking Night", "Meet experts", "2026-03-02", "6:00 PM", "STC212", "asdf@gmail.com");
        Outdoor outdoor = new Outdoor("Spring Picnic", "enjoy spring time", "2026-03-03", "12:00 PM", "Porter Park", "Sunny");

        Console.WriteLine("--- Lecture Marketing ---");
        Console.WriteLine(lecture.GetLectureDetails());

        Console.WriteLine("\n--- Reception Marketing ---");
        Console.WriteLine(reception.GetReceptionDetails());

        Console.WriteLine("\n--- Outdoor Marketing ---");
        Console.WriteLine(outdoor.GetOutdoorDetails());
    }
}