using System;

    class PlayIntDoubleString
    {
        static void Main()
        {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1-- > int");
        Console.WriteLine("2-- > double");
        Console.WriteLine("3-- > string");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                {
                    Console.Write("Please enter int= ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine(n + 1);
                    break;
                }

            case 2:  {
                    Console.Write("Please enter double= ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(n1 + 1);
                    break;
                }
            case 3:
                {
                    Console.Write("Please enter string ");
                    string n2 = Console.ReadLine();
                    Console.WriteLine("{0}*",n2);
                    break;
                }

            default: Console.WriteLine("Not a digit"); break;
        }
    }
    }

