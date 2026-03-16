public class Journal

{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (Entry e in _entries)
        {
            e.Display();
            Console.WriteLine(); 
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {

                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved successfully! {file}");
    }
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            
            string[] lines = File.ReadAllLines(file);

            
            _entries.Clear();

            
            foreach (string line in lines)
            {
                
                string[] parts = line.Split('|');

                
                if (parts.Length == 3)
                {
                   
                    Entry newEntry = new Entry(parts[0], parts[1], parts[2]);

                    
                    _entries.Add(newEntry);
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        } 
    }
}



