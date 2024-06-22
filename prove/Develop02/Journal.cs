using System.IO;
using Microsoft.VisualBasic;
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"{entry.Date} : {entry.PromptText}");
            Console.WriteLine(entry.EntryText);
            Console.WriteLine();
        }
    }

    public void SaveToFile(string _saveFile)
    {
    {
        using (StreamWriter writer = new StreamWriter(_saveFile))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date},{entry.PromptText},{entry.EntryText}");
            }
        }
    }
    }

    
    

    public void LoadFromFile(string file)
    {
       
    }
    
    
}
