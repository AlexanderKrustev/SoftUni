using System;
  class NumberAsWords
    {
        static void Main()
        {
        int number = int.Parse(Console.ReadLine());
        int ones=number % 10;
        int tens = (number / 10) % 10;
        int hunderds = (number / 100) % 10;
        switch (hunderds)
        {
            case 0: Console.Write(""); break;
            case 1: Console.Write("One hundred"); if (tens > 0 || ones > 0) Console.Write(" and "); break;
            case 2: Console.Write("Two hundred"); if (tens > 0 || ones > 0) Console.Write(" and "); break;
            case 3: Console.Write("Three hundred"); if (tens > 0 || ones > 0) Console.Write(" and "); break;
            case 4: Console.Write("Four hundred"); if (tens > 0 || ones > 0) Console.Write(" and "); break;
            case 5: Console.Write("Fife hundred"); if (tens > 0 || ones > 0) Console.Write(" and "); break;
            case 6: Console.Write("Six hundred"); if (tens > 0 || ones > 0) Console.Write(" and "); break;
            case 7: Console.Write("Seven hundred"); if (tens > 0 || ones > 0) Console.Write(" and "); break;
            case 8: Console.Write("Eight hundred"); if (tens > 0 || ones > 0) Console.Write(" and "); break;
            case 9: Console.Write("Nine hundred"); if (tens > 0 || ones > 0) Console.Write(" and "); break;
        }
        switch (tens)
        {
            case 0: Console.Write(""); break;
            case 1:
                {
                    switch (ones)
                    {
                        case 0: Console.WriteLine("ten"); break;
                        case 1: Console.WriteLine("eleven"); break;
                        case 2: Console.WriteLine("twelve"); break;
                        case 3: Console.WriteLine("thirteen"); break;
                        case 4: Console.WriteLine("fourteen"); break;
                        case 5: Console.WriteLine("fifteen"); break;
                        case 6: Console.WriteLine("fixteen"); break;
                        case 7: Console.WriteLine("feventeen"); break;
                        case 8: Console.WriteLine("eighteen"); break;
                        case 9: Console.WriteLine("nineteen"); break;
                    }
                    break;
                }
               
            case 2: Console.Write("twenty "); break;
            case 3: Console.Write("thirty "); break;
            case 4: Console.Write("fourty "); break;
            case 5: Console.Write("fifty "); break;
            case 6: Console.Write("sixty "); break;
            case 7: Console.Write("seventy "); break;
            case 8: Console.Write("eightty "); break;
            case 9: Console.Write("ninety "); break;
        }
        if (tens != 1)
        {
            switch (ones)
            {
                case 0: if (hunderds == 0 && tens == 0) Console.Write("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("fife"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
            }
        }
        }
    }

