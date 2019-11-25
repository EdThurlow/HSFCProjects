using System;

namespace The_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num1;
            int num2;
            int answerA;

          
            int userScore = 0;


            int option;
            do
            {
                Console.WriteLine("1 Addition");
                Console.WriteLine("2 Subtraction");
                Console.WriteLine("3 multiplication");
                Console.WriteLine("4 Display Score");
                Console.WriteLine("5 Change level");
                Console.WriteLine("6 Quit");
                Console.WriteLine("Please enter option (1-6)");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("ADDITION");

                        for (int count =0; count <10; count++)
                        {

                            num1 = rnd.Next(0, 101);// delivers a random value from 1 to 100
                            num2 = rnd.Next(0, 101);// delivers a random value from 1 to 100

                            Console.WriteLine("what is the sum of {0} + {1}", num1, num2);

                            answerA = Convert.ToInt32(Console.ReadLine());


                            if (answerA == (num1 + num2))
                            {
                                Console.WriteLine("correct");
                                userScore = userScore + 1;

                            }
                           else 
                            {
                                Console.WriteLine("incorrect, try another");
                            }

                            Console.ReadKey();

                        }

                        break;
                    case 2:



                        Console.WriteLine("SUBTRACTION");


                        for (int count = 0; count < 10; count++)
                        {
                            num1 = rnd.Next(0, 101);// delivers a random value from 1 to 100
                            num2 = rnd.Next(0, 101);// delivers a random value from 1 to 100

                            Console.WriteLine("what is {0} - {1}", num1, num2);

                            answerA = Convert.ToInt32(Console.ReadLine());

                            if (answerA == (num1 - num2))

                            {
                                Console.WriteLine("correct");
                                userScore = userScore + 1;
                            }

                            else
                            {
                                Console.WriteLine("incorrect, try another");
                            }
                            Console.ReadKey();

                        } 

                        break;
                    case 3:


                        Console.WriteLine("MULTIPLICATION");

                        for (int count = 0; count < 10; count++)
                        {
                            num1 = rnd.Next(0, 101);// delivers a random value from 1 to 100
                            num2 = rnd.Next(0, 101);// delivers a random value from 1 to 100

                            Console.WriteLine("what is {0} * {1}", num1, num2);

                            answerA = Convert.ToInt32(Console.ReadLine());

                            if (answerA == (num1 * num2))
                            {
                                Console.WriteLine("correct");
                                userScore = userScore + 1;
                            }

                            else
                            {
                                Console.WriteLine("incorrect, try another");
                            }
                            Console.ReadKey();

                        } 
                        break;
                    case 4:
                        Console.WriteLine("Your Score is " + userScore);
                        break;
                    case 5:
                        Console.WriteLine("1 Addition");
                        Console.WriteLine("2 Subtraction");
                        Console.WriteLine("3 multiplication");
                        Console.WriteLine("Please enter options (1-3)");
                        break;
                    case 6:
                        Console.WriteLine("Thank you you for playing, good bye!");
                        break;
                }

            } while (option != 6);

        } 
    }
}
