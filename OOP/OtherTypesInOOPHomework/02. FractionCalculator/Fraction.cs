using System;

    public struct Fraction
    {
    private long numerator;
    private long denominator;

    public long Numerator
    {
        get { return this.numerator; }
        set
        {
            if(value< -9223372036854775808 || value> 9223372036854775807)
            {
                throw new ArgumentOutOfRangeException("The numerator should be in range: [-9223372036854775808...9223372036854775807]");
            }
            this.numerator = value;
        }
    }
    public long Denominator
    {
        get { return this.denominator; }
        set
        {
            if (value < -9223372036854775808 || value > 9223372036854775807||value==0)
            {
                throw new ArgumentOutOfRangeException("The denominator should be in range: [-9223372036854775808...9223372036854775807] and cannot be zero.");
            }
            this.denominator = value;
        }
    }

    public static Fraction operator +(Fraction fr1,Fraction fr2)
    {
        Fraction result = new Fraction();
        if (fr1.Denominator == fr2.Denominator)
        {
            result.Numerator = fr1.Numerator + fr2.Numerator;
            result.Denominator = fr1.Denominator;
        }
        else
        {
            result.Numerator = ((LCM(fr1.Denominator, fr2.Denominator) / fr1.Denominator) * fr1.Numerator) + ((LCM(fr1.Denominator, fr2.Denominator) / fr2.Denominator) * fr2.Numerator);
            result.Denominator = LCM(fr1.Denominator, fr2.Denominator);
        }
        return result;
    }
    public static Fraction operator -(Fraction fr1, Fraction fr2)
    {
        Fraction result = new Fraction();
        if (fr1.Denominator == fr2.Denominator)
        {
            result.Numerator = fr1.Numerator - fr2.Numerator;
            result.Denominator = fr1.Denominator;
        }
        else
        {
            result.Numerator = ((LCM(fr1.Denominator, fr2.Denominator) / fr1.Denominator) * fr1.Numerator) - ((LCM(fr1.Denominator, fr2.Denominator) / fr2.Denominator) * fr2.Numerator);
            result.Denominator = LCM(fr1.Denominator, fr2.Denominator);
        }
        return result;
    }
    public static long LCM(long a,long b)
    {
        long num1, num2;
        if (a > b)
        {
            num1 = a; num2 = b;
        }
        else
        {
            num1 = b; num2 = a;
        }

        for (long i = 1; i <= num2; i++)
        {
            if ((num1 * i) % num2 == 0)
            {
                return i * num1;
            }
        }
        return num2;
    }

    public Fraction(long numerator, long denominator):this()
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    public override string ToString()
    {
        double resul1 = (double)this.Numerator / (double)this.Denominator;
        return string.Format("{0}",resul1);
    }
}