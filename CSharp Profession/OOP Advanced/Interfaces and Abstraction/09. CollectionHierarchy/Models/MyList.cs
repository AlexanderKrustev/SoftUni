
namespace _09.CollectionHierarchy.Models
{
   
    using Interfaces;

    public class MyList : AddRemoveCollection, IUsable
    {
        
        public override string Remove()
        {
            string result = this.InnerCollection[0];
            this.InnerCollection.RemoveAt(0);
            return result;
        }

        public int Count()
        {
            return this.InnerCollection.Count;
        }
    }
}
