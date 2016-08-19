namespace _05.BorderControl
{
    public interface IBirthable
    {
        string Birthdate { get; }

        void CheckBirthdate(string pattern);

    }
}
