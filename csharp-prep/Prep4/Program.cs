using System;


class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int minValue = 99999;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter Number.  ");
        int number = int.Parse(Console.ReadLine());
        
        while (number != 0)
        {
            numberList.Add(number);
            Console.Write("Enter Number.  ");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The sum is: {numberList.AsQueryable().Sum()}");
        Console.WriteLine($"The average is: {numberList.AsQueryable().Average()}");
        Console.WriteLine($"The largest is: {numberList.Max()}");

        foreach (int numValue in numberList)
        {
            if (numValue > 0)
            {
                if (numValue < minValue)
                {
                    minValue = numValue;
                }

            }
            
        }

        Console.WriteLine($"The smallest positive number is: {minValue}");
        Console.WriteLine("The sorted list is:");
        numberList.Sort();

        foreach (var item in numberList)
        {
            Console.WriteLine(item);
        }

    }
}