using System;

    class BeerTime
    {
        static void Main()
        {
        System.Globalization.CultureInfo cultureinfo =new System.Globalization.CultureInfo("en-US");
        DateTime time = new DateTime();
        DateTime time1 = DateTime.Parse("03:00 AM",cultureinfo);
        DateTime time2 = DateTime.Parse("01:00 PM",cultureinfo);
        bool isTime = false;
        try
        {


            Console.WriteLine("Please enter time in hh:mm tt format");
            time = DateTime.Parse(Console.ReadLine(), cultureinfo);
            isTime = true;
        }
        catch
        {
            Console.WriteLine("Invalid time");
        }
        if (isTime)
        {
            if (time >= time1 && time>= time2)
            {
                Console.WriteLine("Beer time");
            }
            else
            {
               
                Console.WriteLine("non-beer time");
            }
        }
        }
    }

