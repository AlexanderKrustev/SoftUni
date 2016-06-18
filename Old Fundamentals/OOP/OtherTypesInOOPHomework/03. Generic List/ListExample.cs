using System;
using System.Runtime.InteropServices;

namespace _03.Generic_List
{
    using System.Collections.Generic;

    class ListExample
    {
        static void Main()
        {

            GenericList<int> list1 = new GenericList<int>();
            List<int> alabala=new List<int>();
            alabala.Add(1);
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);
            list1.Add(1);
            list1.Add(3);
            list1.Add(2);
            Console.WriteLine("-====Printing Generic List====-");
            Console.WriteLine(list1);
            Console.WriteLine("-====End Of Printing====-");
            Console.WriteLine();
            Console.WriteLine("Min="+list1.Min());
            Console.WriteLine("Max=" + list1.Max());
            Console.WriteLine("Element in index 5 is",list1[5]);
            Console.WriteLine("Removing element on at index 2");
            list1.RemoveAtIndex(2);
            Console.WriteLine("-====Printing Generic List====-");
            Console.WriteLine(list1);
            Console.WriteLine("-====End Of Printing====-");
            Console.WriteLine();
            Console.WriteLine("Inserting element 10 on at index 5");
            list1.InsertAt(5,2);
            Console.WriteLine("-====Printing Generic List====-");
            Console.WriteLine(list1);
            Console.WriteLine("-====End Of Printing====-");
            Console.WriteLine();
            Console.WriteLine("The index of element {0} is index {1}",6,list1.IndexOf(6));
            Console.WriteLine("The List contains element 5 : {0}",list1.Contains(5));
            Console.WriteLine("The List contains element 5 : {0}", list1.Contains(50));
            Console.WriteLine("Min element of the list is {0}",list1.Min());
            Console.WriteLine("Max element of the list is {0}", list1.Max());
            Console.WriteLine("The max size of the list is {0}",list1.ActuallCapacity);
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);
            list1.Add(1);
            list1.Add(3);
            list1.Add(2); 
            list1.Add(5);
            list1.Add(6);
            list1.Add(1);
            list1.Add(3);
            list1.Add(2);
            Console.WriteLine("-====Printing Generic List====-");
            Console.WriteLine(list1);
            Console.WriteLine("-====End Of Printing====-");
            Console.WriteLine("The max size of the list is {0}", list1.ActuallCapacity);
        }
    }
}
