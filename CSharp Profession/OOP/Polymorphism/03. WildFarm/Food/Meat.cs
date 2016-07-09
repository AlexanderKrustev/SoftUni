namespace _03.WildFarm.Food
{
    public class Meat : Food
    {
        public const string Type = "Meat";

        public Meat(int qty) :
            base(Type,qty)
        {
        }
    }
}