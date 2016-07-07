namespace _06.PrimeChecker
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Number num=new Number(input);

            Console.WriteLine($"{num.nextPrime}, {num.isPrime}");
        }
    }

    public class Number
    {
        private int number;
        public string isPrime = "false";
        public int nextPrime;

        public Number(int number)
        {
            this.number = number;
            Init();
        }

        public void Init()
        {
            if (PrimeCheck(this.number))
            {
                this.isPrime = "true";
            }
            else
            {
                this.isPrime = "false";
                
            }
            nextPrime = NextPrime(number);
        }

        public bool PrimeCheck(int n)
        {
            if (n == 0)
            {
                return true;
            }
            if (n == 1)
            {
                return true;
            }
            
                for (int i = 2; i < n; i++)
                {
                    if (n%i == 0)
                    {
                        return false;
                    }
                }
           

            return true;
        }

        public int NextPrime(int n)
        {
            n++;
            while (true)
            {

                if (PrimeCheck(n))
                {

                    return n;
                }
                n++;
            }
        }
    }
}
