using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.GetDate()},{entry.GetPrompt()},{entry.GetResponse()}");
            }
        }
    }


    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        if (File.Exists(filename))
        {
            foreach (var line in File.ReadAllLines(filename))
            {
                var parts = line.Split(',', 3);
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[1], parts[2], parts[0]));
                }
            }
        }
    }

}
