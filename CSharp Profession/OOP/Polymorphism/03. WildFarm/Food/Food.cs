namespace _03.WildFarm.Food
{
    public abstract class Food
    {
        private int qty;
        private string type;

        protected Food(string type, int qty)
        {
            this.type = type;
            this.qty = qty;
        }

        public string Type => this.type;

        public int QTY => this.qty;
    }
}