using System;


class JoroFootball
{
    private static double playedweeks;

    static void Main(string[] args)
    {
        int holydays = 0;
        int homeWeeks = 0;
        String isLeapY = null;
        isLeapY = Console.ReadLine();
        holydays = int.Parse(Console.ReadLine());
        homeWeeks = int.Parse(Console.ReadLine());
        double playedWeeks = 0;
        playedWeeks = 52;
        playedWeeks = (playedWeeks * 2) / 3;
        playedWeeks = playedWeeks + (holydays * 0.5);
        if (isLeapY == "t")
        {
            Console.WriteLine(playedWeeks);
            playedWeeks = playedWeeks + 3;
        }

        Console.WriteLine((int)playedWeeks);

    }
}


