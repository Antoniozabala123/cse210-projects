using System;

// These are the variables that store the comment information method enpcasulation 
public class Comment
{
    private string _name;
    private string _text;
    //It is executed at the exact moment you create a comment (e.g., new Comment("Juan", "Good video!")).
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    // get and setter
    public string GetName()

    {
        return _name;

    }
    //These methods act as a "window" that allows other parts of the program to obtain the author's name or the content of the comment without giving them permission to modify it.
    public string GetText()
    {
        return _text;
    }
    public string GetDisplayText()
    {
        return $"{_name}:{_text} ";

    }
}
