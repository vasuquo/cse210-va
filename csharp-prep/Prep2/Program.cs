using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter score in percentage ");
        string scoreInPercent = Console.ReadLine();
        int score = int.Parse(scoreInPercent);
        string letter = "";
        string sign = "";
        int lastDigit = score % 10;

        if (score >= 90)
        {            
            letter = "A";
        } 
        else if (score >= 80)
        {            
            letter = "B";
        } 
        else if (score >= 70)
        {
            letter = "C";
        } 
        else if (score >= 60)
        {
            letter = "D";
        } 
        else 
        {
            letter = "F";
        }

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        } 
        else 
        {
            sign = " ";
        }

        if (letter == "A" || letter == "F") 
        {
            sign = " ";
        }



        Console.WriteLine($"Your grade is {letter}{sign}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations! you passed the course");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass the course. Better luck next time.");
        }

        

    }
}