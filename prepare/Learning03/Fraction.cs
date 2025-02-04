class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction() 
    {numerator = 1; denominator = 1;}
    public Fraction(int _numerator) 
    {
        denominator = 1;
        numerator = _numerator;

    }
    public Fraction(int _numerator, int _denominator) 
    {
        numerator = _numerator;
        denominator = _denominator;
    }
    
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }
    public double GetDecimalValue()
    {
        return (double)numerator/(double)denominator;
    }
}
