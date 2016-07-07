namespace _06.RawData
{
    public class Tire
    {
        public double pressure1;
        public double pressure2;
        public double pressure3;
        public double pressure4;
        public int age1;
        public int age2;
        public int age3;
        public int age4;

        public Tire(double p1, int a1, double p2, int a2, double p3, int a3, double p4, int a4)
        {
            this.pressure1 = p1;
            this.pressure2 = p2;
            this.pressure3 = p3;
            this.pressure4 = p4;
            this.age1 = a1;
            this.age2 = a2;
            this.age3 = a3;
            this.age4 = a4;
        }
    }
}
