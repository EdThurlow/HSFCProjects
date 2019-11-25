using System;

namespace PersonProject
{
    class Program
    {
       public static void Main(string[] args)
        {
            Person p1 = new Person(); //set the name
            p1.GetName(Console.ReadLine()); // set the age
            p1.SetAge(Convert.ToInt32(Console.ReadLine()); // write out the name and age
            Console.WriteLine(p1.GetName() + "is aged" + p1.GetAge());
        }
    }
}
