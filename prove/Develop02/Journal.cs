using System;
using System.Collections.Generic;
public class Journal 
{

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        Console.WriteLine("All Entries:");
        foreach ( var Entry in _entries)
        {
            Entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var Entry in _entries)
            {
                writer.WriteLine($"{Entry._date}, {Entry._promptText}, {Entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved to file successfully.");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear(); // Limpiar la lista actual de entradas
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine("Journal loaded from file successfully.");
    }
}