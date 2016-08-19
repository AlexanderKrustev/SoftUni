namespace _05.BorderControl
{
    using System;

    public class Citizen : ICheckable, IBirthable, IBuyer
    {
        public Citizen(string name, string age, string id, string bday)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.Birthdate = bday;

        }

        public string Name { get; }

        public string Age { get; }

        public string ID { get; }

        public string Birthdate { get; }

        public string Group { get; set; }

        public int TotalFood { get; set; }

        public void CheckId(string pattern)
        {
            int index = pattern.Length;

            if (this.ID.Substring(this.ID.Length - index, index) == pattern)
            {
                Console.WriteLine(this.ID);
            }
        }
        

        public void CheckBirthdate(string pattern)
        {
            string[] bdayParams = this.Birthdate.Split('/');
            if (pattern == bdayParams[2])
            {
                Console.WriteLine(this.Birthdate);
            }
        }

      

        public void BuyFood()
        {
            this.TotalFood += 10;
        }
    }
}
