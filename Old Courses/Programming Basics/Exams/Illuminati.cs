using System;

    class Illuminati
    {
        static void Main()
        {
        string input = Console.ReadLine();
        input = input.ToLower();
        long sum = 0;
        int counter = 0;
        for(int x=0;x<input.Length;x++)
        {
            switch (input[x])
            {
                case 'a':
                    {
                        sum += 65;
                        counter++;
                        break;
                    }
                case 'e':
                    {
                        sum += 69;
                        counter++;
                        break;
                    }
                case 'i':
                    {
                        sum += 73;
                        counter++;
                        break;
                    }
                case 'o':
                    {
                        sum += 79;
                        counter++;
                        break;
                    }
                case 'u':
                    {
                        sum += 85;
                        counter++;
                        break;
                    }
                default: break;
            }
           
        }
        Console.WriteLine(counter);
        Console.WriteLine(sum);
    }
    }

