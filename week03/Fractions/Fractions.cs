using System;

public class Fraction
{
    // Private attributes (encapsulation)
    private int _top;
    private int _bottom;

    // 1. Default constructor (1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // 2. One parameter constructor (top / 1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // 3. Two parameter constructor (top / bottom)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters
    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    // Setters
    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Return fraction as string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}