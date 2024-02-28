using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.Write("What is the magic number? ");
       // int magicNumber = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        string playAgain = "yes";
        while (playAgain == "yes") 
        {
            int magicNumber = rnd.Next(1, 100);
            int guessCount = 0;

            Console.Write("What is your guess? ");
            int guessNumber = int.Parse(Console.ReadLine());

            while (magicNumber != guessNumber)
            {
              if (magicNumber > guessNumber) 
              {
                Console.WriteLine("Higher");
              }
              else if (magicNumber < guessNumber)
              {
                Console.WriteLine("Lower");
              }
              Console.Write("What is your guess? ");
              guessNumber = int.Parse(Console.ReadLine());
              ++guessCount;
        }

          Console.WriteLine($"You guessed it! after {guessCount} trials");

          Console.Write("Play again? ");
          playAgain = Console.ReadLine();

        }
        
    }
}