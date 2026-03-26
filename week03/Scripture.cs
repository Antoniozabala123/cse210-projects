using System;
using System.Collections.Generic;

public class Scripture
{
    // Private attributes
    private string _References;

    private List<Word> _words;

    // this is constructor  receive the references text completed then divide the text in a list object in "word"
    public Scripture(References references, string text)
    {
        _References = Reference;

        _words = new List<Word>();

        string[] splitWords = text.Split(' ');

        foreach (string splitWords in text.split)

            _words.Add(new Word(wordText));
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rng = new Random();

        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = rng.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

}
   