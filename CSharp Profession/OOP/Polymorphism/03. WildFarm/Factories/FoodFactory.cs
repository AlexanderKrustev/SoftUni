namespace _03.WildFarm.Factories
{
    using Food;

    public class FoodFactory
    {

        public Food CreateFood(string type, int qty)
        {
            if (type == "Vegetable")
            {
                return new Vegetable(qty);
            }
            else
            {
                return  new Meat(qty);
            }
        }
    }
}
