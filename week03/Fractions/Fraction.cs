using System;
using System.Dynamic;

public class fraction
{
    private int _top;
    private int _bottom;

    public fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_bottom}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}

