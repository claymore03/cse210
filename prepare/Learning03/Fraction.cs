public class Fraction
{
    private int _topNum;

    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int wholeNum)
    {
        _topNum = wholeNum;
        _bottomNum = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _topNum = numerator;
        _bottomNum = denominator;
    }

    public string DisplayFractionString()
    {
        string text = $"{_topNum}/{_bottomNum}";
        return text;
    }

    public double CalculateDecimalValue()
    {
        return (double)_topNum / (double)_bottomNum;
    }
}    