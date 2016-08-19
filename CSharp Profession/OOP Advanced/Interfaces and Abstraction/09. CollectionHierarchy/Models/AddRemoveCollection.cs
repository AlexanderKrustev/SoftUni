namespace _09.CollectionHierarchy.Models
{
    using Interfaces;

    public class AddRemoveCollection : AddCollection , IRemovable
    {
        public override int Add(string item)
        {
            this.InnerCollection.Insert(0,item);

            return 0;
        }

        public virtual string Remove()
        {
            string result = base.InnerCollection[base.InnerCollection.Count - 1];
            this.InnerCollection.RemoveAt(base.InnerCollection.Count-1);

            return result;
        }
    }
}
