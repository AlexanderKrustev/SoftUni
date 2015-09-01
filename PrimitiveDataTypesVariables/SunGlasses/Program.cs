using System;


   class Program
    {
        static void Main()
        {
        int height = int.Parse(Console.ReadLine());
        int width = 2 * height;

        Console.Write(new string('*', width));
        Console.Write(new string(' ', height));
        Console.Write(new string('*', width));
        Console.WriteLine();
        for(int x = 1; x < height-1; x++)
        {
            Console.Write(new string('*', 1));
            Console.Write(new string('/', width-2));
            Console.Write(new string('*', 1));
            if(x== (height / 2 ))
            {
                Console.Write(new string('|', height));
            }
            else
            {
                Console.Write(new string(' ', height));
            }
            
            Console.Write(new string('*', 1));
            Console.Write(new string('/', width - 2));
            Console.Write(new string('*', 1));
            Console.WriteLine();
        }
        Console.Write(new string('*', width));
        Console.Write(new string(' ', height));
        Console.Write(new string('*', width));
        Console.WriteLine();
    }
    }

