namespace _08.MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface ISpecialisedSoldier : IPrivate
    {
       string Corpus { get; set; }
    }
}
