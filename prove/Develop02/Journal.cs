using System.IO;
using System.Text.Json;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {                             
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entryItem in _entries)
        {
            entryItem.Display();
        }

        Console.Write("Press Enter to continue...");
        string dummy = Console.ReadLine();
    }

    public void SaveToFile(string fileName)
    {
        using (var writer = new StreamWriter(fileName))
        {
            foreach (Entry entryItem in _entries)
            {
                writer.WriteLine($"{entryItem._date},{entryItem._promptText},{entryItem._entryText}");
            }
        }

    }

    public void LoadFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
                        
        foreach (string line in lines)
        {
            
            string[] values = line.Split(',');
            string promptText;
            string entryText;
            string dateText;
                            
            dateText = values[0];

            if (values.Length > 3) 
            {
                promptText = $"{values[1]}, {values[2]}";
            }
            else
            {
                promptText = values[1];
            }
            
            entryText = values[values.Length-1];
            Entry entry = new Entry(dateText, promptText, entryText);                        
            AddEntry(entry);
        }
                                                                                            
    }

    
}