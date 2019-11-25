using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GuessTheNumber"); //generate seed for a random number
            Random rnd = new Random();
            int intNumber;
            int intGuess;
            intNumber = rnd.Next(0, 101); // delivers a random value from 1 to 100
            intGuess = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter your guess between 1 and 100");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess > intNumber)
                {
                    Console.WriteLine("Too High");

                }
                if (intGuess < intNumber)
                {
                    Console.WriteLine("Too Low");
                }
                if (intGuess == intNumber)
                {
                    Console.WriteLine("You got it!");
                }
                Console.ReadLine();
            } while (intGuess != intNumber);
        }
    }
}
