using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class Program
    {
        static void Main(string[] args)
        {

            Persons sasho = new Persons("", 29, "a.krustev@agria.bg");
            Persons.ToString(sasho);
        }
    }
}
