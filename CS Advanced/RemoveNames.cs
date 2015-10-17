using System;

using System.Linq;

    class RemoveNames
    {
        static void Main(string[] args)
        {
            string mainList = Console.ReadLine();
            string names = Console.ReadLine();
            string[] arr1 = mainList.Split(' ');
            string[] arr2 = names.Split(' ');
            
            string result = "";
            foreach(string s in arr1)
            {
                if (!arr2.Contains(s))
                {
                    result = result + " " + s;
                }
                
            }
            Console.WriteLine(result.Trim());
            
    
        }
    }
}
