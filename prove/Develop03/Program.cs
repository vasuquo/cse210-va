using System;

class Program
{
    static void Main(string[] args)
    { 
         //In exceeding requirement verses are loaded from a text file "verses.txt"
             
        string[] lines = File.ReadAllLines("verses.txt");
        Random rnd = new Random();        
        int index = rnd.Next(lines.Length);
        Scripture scripture = new Scripture(lines[index]);
        //Console.WriteLine(scripture.GetDisplayText());
    }
}