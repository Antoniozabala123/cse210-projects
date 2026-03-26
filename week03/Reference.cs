using System;
using System.Collections.Generic;

public class Reference
{
    private string _book;

    private int _chapter;

    private int _verse;

    private int _endverse;

    public Reference(string _book, int _chapter, int _verse, int _endverse)
    {
        _book = _book;

        _chapter = _chapter;

        _verse = _verse;

        _endverse = _endverse;
    }
    public void references(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public void references(string book, int chapter, int verse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = endverse;
    }

    public void GetDisplayText()
    {
        {
            if (_endverse == 0)
            {
                return $"{_book} {_chapter}:{_verse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_verse}{_endverse}";
            }
        }
    } 
}