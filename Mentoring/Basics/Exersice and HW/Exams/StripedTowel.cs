using System;

class StripedTowel
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        double height = Math.Floor(1.5 * width);
        for (int x = 0; x < height; x++)
        {
            for (int z = 0; z < width; z++)
            {
                if (x % 3 == 0) {
                    if (z % 3 == 0 )
                    {
                        Console.Write("#");

                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                else if ((x-1) % 3 == 0) 
                {
                    if ((z-2)%3==0)
                    {
                        Console.Write("#");

                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                else if ((x-2) % 3 == 0)
                {
                    if ((z - 1) % 3 == 0)
                    {
                        Console.Write("#");

                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }
            Console.WriteLine();
           
        }
            
     }
}



