using System;
using System.Text;

class PrintASCII
    {
        static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.UTF8;
        for ( int x = 0; x < 255; x++)
        {
            Console.WriteLine((char)x);
        }
        }
    }

