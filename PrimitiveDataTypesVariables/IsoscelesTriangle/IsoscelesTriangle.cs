using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;  //adjust the encoding allow using special symbols
        int row = 9;
        Console.WriteLine("Please enter row count");
        row = int.Parse(Console.ReadLine()); // optional , the program works with diferent size of triangel. This row asks the user for row count== Symbol count
        int countAsterix = 0;
        int spaceMiddle = 0;
        Console.Write(new string(' ', row - 1));  //Next 3 rows print first row of the figure
        Console.Write(new string('©', 1));
        Console.Write(new string(' ', row - 1));
        Console.WriteLine();
        for (int x = 1; x < row - 1; x++) //Prints middle rows from 2 to row-1
        {
            spaceMiddle = (x * 2) - 1;
            int spacesLeft = (row - 1) - x;
            Console.Write(new string(' ', spacesLeft));
            Console.Write(new string('©', 1));
            Console.Write(new string(' ', spaceMiddle));
            Console.Write(new string('©', 1));
            Console.WriteLine();
            countAsterix++;
        }
        for (int a = countAsterix + 2; a > 0; a--) //Prints last row
        {
            Console.Write(new string('©', 1));
            Console.Write(new string(' ', 1));
        }
        Console.WriteLine();
    }


}


    }

