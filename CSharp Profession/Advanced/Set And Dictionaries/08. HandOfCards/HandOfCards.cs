namespace _08.HandOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandOfCards
    {
        public static void Main()
        {
            Dictionary<string, HashSet<string>> data = new Dictionary<string, HashSet<string>>();
            string input = Console.ReadLine();

            while (!input.Equals("JOKER"))
            {
                int indexOfDelimiter = input.IndexOf(":", 0);
                string name = input.Substring(0, indexOfDelimiter);
                string[] cards =
                    input.Substring(indexOfDelimiter + 1)
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (data.ContainsKey(name))
                {
                    foreach (string card in cards)
                    {
                        data[name].Add(card);
                    }
                }
                else
                {
                    data.Add(name, new HashSet<string>());

                    foreach (string card in cards)
                    {
                        data[name].Add(card);
                    }
                }
                
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, HashSet<string>> kvp in data)
            {
                int cardPoints = kvp.Value.Sum(card => CalculateHand(card));

                Console.WriteLine($"{kvp.Key}: {cardPoints}");
            }
        }

        public static int CalculateHand(string card)
        {
            int result = 0;
            int power = 0;
            int sign = 0;
            string powerStr = "";
            string signStr = card.Substring(card.Length - 1);
            if (card.Length > 2)
            {
                powerStr = card.Substring(0, 2);
            }
            else
            {
                powerStr = card.Substring(0, 1);
            }

            switch (powerStr)
            {
                case "1":
                    {
                        power = 1;
                    }
                    break;
                case "2":
                    {
                        power = 2;

                    }
                    break;
                case "3":
                    {
                        power = 3;
                    }
                    break;
                case "4":
                    {
                        power = 4;
                    }
                    break;
                case "5":
                    {
                        power = 5;
                    }
                    break;
                case "6":
                    {
                        power = 6;
                    }

                    break;
                case "7":
                    {
                        power = 7;

                    }
                    break;

                case "8":
                    {
                        power = 8;
                    }
                    break;

                case "9":
                    {
                        power = 9;
                    }
                    break;

                case "10":
                    {
                        power = 10;
                    }
                    break;
                case "J":
                    {
                        power = 11;
                    }
                    break;
                case "Q":
                    {
                        power = 12;
                    }
                    break;
                case "K":
                    {
                        power = 13;
                    }
                    break;
                case "A":
                    {
                        power = 14;
                    }
                    break;
            }

            switch (signStr)
            {
                case "S":
                    {
                        sign = 4;
                    }
                    break;
                case "H":
                    {
                        sign = 3;
                    }
                    break;
                case "D":
                    {
                        sign = 2;
                    }
                    break;
                case "C":
                    {
                        sign = 1;
                    }
                    break;
            }

            return sign * power;
        }
    }
}
