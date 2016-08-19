namespace _04.Telephony
{
    using System;
    using System.Text.RegularExpressions;

    public class Smartphone : IBrowser, ICaller
    {
        public Smartphone(string[] numbers, string[] urls)
        {
            this.Numbers = numbers;
            this.URLS = urls;
        }

        public string[] Numbers { get; set; }

        public string[] URLS { get; set; }

        public void Browse()
        {
            Regex regex = new Regex(@"\d+");


            foreach (var url in this.URLS)
            {
                Match match = regex.Match(url);
                if (match.Success)
                {
                    Console.WriteLine("Invalid URL!");
                    
                }
                else
                {
                    Console.WriteLine("Browsing: {0}!", url);
                }
            }
        }

        public void Call()
        {
            {
                Regex regex = new Regex(@"[A-z]+");


                foreach (var number in this.Numbers)
                {
                    Match match = regex.Match(number);
                    if (match.Success)
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    else
                    {
                        Console.WriteLine("Calling... {0}", number);
                        
                    }
                }
            }
        }
    }
}
