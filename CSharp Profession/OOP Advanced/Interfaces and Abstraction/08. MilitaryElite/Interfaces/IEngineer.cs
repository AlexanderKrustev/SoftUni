namespace _08.MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface IEngineer :ISpecialisedSoldier
    {
        IList<IPart> Repairs { get; }
    }
}
