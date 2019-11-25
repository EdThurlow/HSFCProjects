using System;

namespace Coach_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach myCoach = newCoach();

            for(int i =0; i<5; i++)
            {
                Person p = newPerson();
                Console.WriteLine("Enter Name");
                p.SetName(Console.ReadLine());

                if (myCoach.AddPerson(p) == true)
                    Console.WriteLine("You have a seat");
                else
                    Console.WriteLine("Get out of my coach");
            }
        }
    }
}
