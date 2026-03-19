public class Journal

{
    public List<Entry> _entries = new List<Entry>();

    // List that stores all the "Entry" type objects in the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!");
    }
    //It iterates through the list and displays all entries. If it is empty, it notifies the user.
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
    // people can save up comment in archive txt 
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

    //Check if the file physically exists on the disk  
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



