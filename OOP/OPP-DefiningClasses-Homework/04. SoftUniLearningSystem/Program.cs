using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniLearningSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Alex", "Krustev", 29);
            
            SeniorTrainer tr1 = new SeniorTrainer("Alex", "Krustev", 29);
            tr1.DeleteCourse("Asdsds");
            Console.WriteLine(tr1.ToString());
            

        }
    }
}
