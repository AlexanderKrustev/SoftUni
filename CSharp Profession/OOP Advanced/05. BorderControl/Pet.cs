namespace _05.BorderControl 
{
    using System;

    public class Pet: IBirthable
    {
        public Pet(string name, string bdate)
        {
            this.Name = name;
            this.Birthdate = bdate;
        }

        public string Name { get; }

        public string Birthdate { get; }

        public void CheckBirthdate(string pattern)
        {
            string[] bdayParams = this.Birthdate.Split('/');
            if (pattern == bdayParams[2])
            {
                Console.WriteLine(this.Birthdate);
            }
        }
    }
}
