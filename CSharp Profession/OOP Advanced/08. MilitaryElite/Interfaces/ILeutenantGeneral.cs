namespace _08.MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public  interface ILeutenantGeneral : IPrivate
    {
        IList<IPrivate> PrivatesUnderCommand { get; }
     }
}
