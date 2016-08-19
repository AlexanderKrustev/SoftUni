namespace _05.BorderControl
{
    using System;

    public class Robot : ICheckable
    {

        public Robot(string model, string id)
        {
            this.Model = model;
            this.ID = id;
        }

        public string Model { get; }

        public string ID { get; }

        public void CheckId(string pattern)
        {
            int index = pattern.Length;

            if (this.ID.Substring(this.ID.Length - index, index) == pattern)
            {
                Console.WriteLine(this.ID);
            }
        }
    }
}
