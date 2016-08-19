namespace _05.BorderControl
{
    public interface ICheckable
    {
        string ID { get; }

        void CheckId(string pattern);
    }
}
