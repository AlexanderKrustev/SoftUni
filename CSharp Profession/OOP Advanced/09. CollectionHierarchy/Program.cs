namespace _09.CollectionHierarchy
{
    using System;
    using Interfaces;
    using Models;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            IAddable addList=new AddCollection();
            IRemovable addRemoveList = new AddRemoveCollection();
            IUsable myList = new MyList();

            foreach (var str in input)
            {
                Console.Write(addList.Add(str)+" ");
                
            }
            Console.WriteLine();
            foreach (var str in input)
            {
                Console.Write(addRemoveList.Add(str) + " ");

            }
            Console.WriteLine();
            foreach (var str in input)
            {
                Console.Write(myList.Add(str) + " ");

            }
            Console.WriteLine();

            int removesCount = int.Parse(Console.ReadLine());

            
                for (int j = 0; j < removesCount; j++)
                {
                    Console.Write(addRemoveList.Remove()+" ");
                }
                Console.WriteLine();
                for (int j = 0; j < removesCount; j++)
                {
                    Console.Write(myList.Remove() + " ");
                }
            Console.WriteLine();

        }
    }
}
