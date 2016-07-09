namespace _03.WildFarm.Food
{
    public class Vegetable : Food
    {
        public const string Type = "Vegetable";

        public Vegetable( int qty) 
            : base(Type, qty)
        {
        }
    }
}