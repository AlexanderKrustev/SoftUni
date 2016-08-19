namespace _05.BorderControl
{
    public interface IBuyer
    {
        string Group { get; set; }
        int TotalFood { get; set; }
        void BuyFood();
    }
}
