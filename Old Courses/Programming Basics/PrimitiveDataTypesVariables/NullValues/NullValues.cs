using System;

    class NullValues
    {
        static void Main()
        {
        int? value1 = null;
        double? values2 = null;
        Console.WriteLine(value1);
        Console.WriteLine(values2);
        value1 = value1 + 10;
        values2 = values2 + 10;
        Console.WriteLine(value1);
        Console.WriteLine(values2);
        value1 = 0;
        values2 = 0;
        value1 = value1 + 10;
        values2 = values2 + 10;
        Console.WriteLine(value1);
        Console.WriteLine(values2);

    }
    }

