using System;
using System.Collections;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

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
    public Bool Ishidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        {
            if (_isHidden)
                return ('_', text_length);

            else

                return _text;
        }
    } 
}