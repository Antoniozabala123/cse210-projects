using System;
using System.Linq;
namespace ScriptureMemorizer;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Dividimos el texto en palabras y creamos objetos Word
        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        // Intentamos ocultar palabras hasta alcanzar el número o quedarnos sin palabras
        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string textContent = "";
        foreach (Word word in _words)
        {
            textContent += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} - {textContent.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}