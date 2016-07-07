
namespace _11.TimeStamp
{
    using System;

    public class Person
   {
       public string name;
       public DateTime modificationDate;
       


       public Person(string name)
       {
           this.name = name;
           this.modificationDate = DateTime.Now;
       }

       

        
   }
}
