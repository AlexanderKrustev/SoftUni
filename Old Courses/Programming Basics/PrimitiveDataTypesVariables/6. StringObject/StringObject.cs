using System;

    class StringObject
    {
        static void Main()
        {
        string string1 = "Hello";
        string string2 = "World";
        object string3 = string1 + " " + string2;
        string string4;
        string4 = (string)string3;
        Console.WriteLine(string4);
    }
    }
