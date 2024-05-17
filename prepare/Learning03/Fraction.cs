using System;

public class Fraction 
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }

    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //public int Top   -------- 5.1) Create getters and setters for both the top and the bottom values.
    //{
        //get { return _top; }
        //set { _top = value; }
    //}

    //public int Bottom
    //{
        //get { return _bottom; }
        //set { _bottom = value; }
    //}

    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }


}

