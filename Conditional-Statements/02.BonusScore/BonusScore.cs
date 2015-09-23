using System;



    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you scroe");
            int score = int.Parse(Console.ReadLine());
            if (score >= 1 && score <= 3)
            {
                Console.WriteLine("Your score is {0}", score * 10);
            }
            else if (score >= 4 && score <= 5)
            {
                Console.WriteLine("Your score is {0}", score * 100);
            }
            else if (score >= 7  && score <= 9)
            {
                Console.WriteLine("Your score is {0}", score * 1000);
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
        }
        }
    
