using System;
 class Cinema
    {
        static void Main()
        {
        string typeOfProject = Console.ReadLine();
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        int numberOfSeats = row * col;
        decimal result = 0;
        switch (typeOfProject)
        {
            case "Premiere":result = numberOfSeats * 12.00m; break;
            case "Normal":  result = numberOfSeats * 7.50m; break;
            case "Discount": result = numberOfSeats * 5.00m; break;
        }
        Console.WriteLine("{0:F2} leva",result);
        }
    }

