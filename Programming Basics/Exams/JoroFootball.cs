using System;


class JoroFootball
{
    private static double playedweeks;

    static void Main(string[] args)
    {
        int pHolydays = 0;
        int homeWeeks = 0;
        String isLeapY = null;
        isLeapY = Console.ReadLine();


        pHolydays = int.Parse(Console.ReadLine());

        homeWeeks = int.Parse(Console.ReadLine());
        double playedWeeks = 0;
        playedWeeks = 52;
        playedWeeks = playedWeeks - homeWeeks;
        playedWeeks = (playedWeeks * 2) / 3;
        playedWeeks = playedWeeks + (pHolydays * 0.5);
        playedWeeks = playedWeeks + homeWeeks;
        if (isLeapY == "t")
        {
            playedWeeks = playedWeeks + 3;
        }

        Console.WriteLine((int)playedWeeks);

    }
}

