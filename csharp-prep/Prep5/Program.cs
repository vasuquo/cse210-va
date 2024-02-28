using System;

class Program
{
    static void Main(string[] args)
    {
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name?  ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number?  ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number) 
        {
            return number * number;
        }

        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, the square is your number is {squared}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);
    }
}