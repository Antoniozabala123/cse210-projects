using System;
using System.Collections.Generic;
// here method use get setter y method enpsulation program
public class Video
{
    private string _title;
    private string _author;
    private int _duration;

    private List<Comment> _comment = new List<Comment>();
    //It receives the initial data (title, author and duration) and stores it in the internal variables (_title, _author, _duration) so that the object "remembers" its own information.
    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;

    }
    //Receives a Comment object and stores it within the private list _comment.
    public void AddComment(Comment comment)
    {
        
        {
            _comment.Add(comment);
        }

    }
    public int GetNumberComment()
    {
        return _comment.Count;
    }
    // display program
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine($"Comments: {GetNumberComment()}\n");
        foreach (var comment in _comment)
        {
        Console.WriteLine($"   {comment.GetDisplayText()}");
        }

        Console.WriteLine(new string('-', 60));
    }

}