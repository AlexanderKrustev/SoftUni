using System;
using System.Collections.Generic;

public class UniqueUsernames
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string username = Console.ReadLine();

        HashSet<string> names = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            names.Add(username);
            username = Console.ReadLine();
        }


        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}



