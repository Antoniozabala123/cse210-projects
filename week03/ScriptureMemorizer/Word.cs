using System;
namespace ScriptureMemorizer;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;

    }
    public void hide()
    {
        _isHidden = true;

    }
    public void show()
    {
        _isHidden = false;

    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        {
            if (_isHidden)
                return new string ('_', _text.Length);

            else

                return _text;
        }
    }
}