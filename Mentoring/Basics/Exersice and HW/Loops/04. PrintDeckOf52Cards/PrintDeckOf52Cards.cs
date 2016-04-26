using System;

    class PrintDeckOf52Cards
    {
        static void Main()
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string[] symbols = { "♥", "♦", "♠", "♣" };

        for (int i = 2; i <= 15; i++)
        {
            foreach(string sign in symbols)
            {
                if (i > 10)
                {
                    
                    switch (i)
                    {
                        
                        case 12: Console.Write("J" + sign); break;
                        case 13: Console.Write("Q" + sign); break;
                        case 14: Console.Write("K" + sign); break;
                        case 15: Console.Write("A" + sign); break;
                    }
                }
                else
                {
                    Console.Write(i + sign);
                }
            }
            if (i != 11)
            {
                Console.WriteLine();
            }

        }
        }
    }

