using System;


class PrintSiquence
{
    static void Main()
    {
        for (int x = 2; x <= 11; x++)
        {

            if (x % 2 == 0)
            {
                Console.Write("{0} ", x);
            }
            else
            {
                Console.Write("-{0} ", x);
            }
         
        }
        Console.WriteLine();
    }
}
    

