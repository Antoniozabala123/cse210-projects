public class Entry

{
    // Member variables (data container)
    public string _date;

    public string _promptText;

    public string _entryText;

    public Entry()
    {
    }

    public Entry(string date, string prompt, string Text)
    {
        _date = date;
        _promptText = prompt;
        _entryText = Text;
    }
    public Entry(string prompt, string Text)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = Text;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText); 
        Console.WriteLine();
    }
}
