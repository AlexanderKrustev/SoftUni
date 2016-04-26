using System;



    class AgeAfter10Years
    {
        static void Main()

    {
        Console.WriteLine("Pleas enter you birthday date in format dd.mm.yyyy");
        String date = Console.ReadLine();

        DateTime myBDate = DateTime.Parse(date);
        DateTime currentDate = DateTime.Now;
        if (currentDate.Month >= myBDate.Month){
            if (currentDate.Month == myBDate.Month && currentDate.Day > myBDate.Day)
            {
                Console.WriteLine("Now: {0}", (currentDate.Year - myBDate.Year));
                Console.WriteLine("After 10 years: {0}", (currentDate.Year - myBDate.Year + 10));
            }
            else
            {
                Console.WriteLine("Now: {0}", (currentDate.Year - myBDate.Year - 1));
                Console.WriteLine("After 10 years: {0}", (currentDate.Year - myBDate.Year + 9));
            }
        }
        else
        {
            Console.WriteLine("Now: {0}", (currentDate.Year - myBDate.Year - 1));
            Console.WriteLine("After 10 years: {0}", (currentDate.Year - myBDate.Year + 9));
        }
    
    }
}

