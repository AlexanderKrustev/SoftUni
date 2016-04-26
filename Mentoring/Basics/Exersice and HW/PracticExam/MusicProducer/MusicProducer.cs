using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
     System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

            long numbersAlbumsEurope = long.Parse(Console.ReadLine());
            decimal priceAlbumEuro=decimal.Parse(Console.ReadLine());
            long numbersAlbumsNA = long.Parse(Console.ReadLine());
            decimal priceAlbumDolars = decimal.Parse(Console.ReadLine());
            long numbersAlbumsSA = long.Parse(Console.ReadLine());
            decimal priceAlbumPesos = decimal.Parse(Console.ReadLine());
            long numberConcerts = long.Parse(Console.ReadLine());
            decimal profitOfConcert = decimal.Parse(Console.ReadLine());
            decimal incomeEurope = (numbersAlbumsEurope * priceAlbumEuro) * 1.94m;
            decimal incomeNA = (numbersAlbumsNA * priceAlbumDolars) * 1.72m;
            decimal incomeSA = (numbersAlbumsSA * priceAlbumPesos)/332.74m;
            decimal AllAlbumsResult = (incomeEurope + incomeNA + incomeSA) - 0.35m * (incomeEurope + incomeNA + incomeSA);
            AllAlbumsResult = AllAlbumsResult - (0.2m * AllAlbumsResult);
            decimal concertProfit = (numberConcerts * profitOfConcert)*1.94m;
            if (concertProfit > 100000)
            {
                concertProfit = concertProfit - (concertProfit * 0.15m);
            }
            if (concertProfit < AllAlbumsResult)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:f2}lv.",AllAlbumsResult);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:f2}lv.",concertProfit);
            }
        }
    }
}
