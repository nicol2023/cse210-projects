using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess;
        string feedback = "";

        while (true)
        {
            Console.WriteLine("What's your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
            feedback = "Higher";
            }
            else if (guess > number)
            {
            feedback = "Lower";
            }
            else
            {
            feedback = "You guessed it!";
            break;
            }

            Console.WriteLine(feedback);
        }

        Console.WriteLine(feedback);
    }
}