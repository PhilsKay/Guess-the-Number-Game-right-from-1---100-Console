using System;

namespace Guess_the_Number_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1,100);
            int userGuess = 0;
            int userGuessCount = 0;
            while(userGuess != secretNumber)
            {
                Console.Write("Guess the secret number from 1 to 100 : ");
                userGuess = int.Parse(Console.ReadLine());
                userGuessCount++;
                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Number is low!");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Number is high!");
                }
                else
                {
                    continue;
                }
            }
            // To applaud the user after guessing correctly
            if (userGuessCount <= 2)
            {
                Console.WriteLine("Excellent!");
            }
            else if (userGuessCount <= 5)
            {
                if (userGuessCount > 2)
                {
                    Console.WriteLine("Good!");
                }
            }
            else
            {
                Console.WriteLine("Fair!");
            }
            Console.WriteLine("Congratulations you got the secret number right in {0} tries.", userGuessCount);
            Console.ReadLine();
        }
    }
}
