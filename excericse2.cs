using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your score: ");
        int score = int.Parse(Console.ReadLine());

        if (score >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (score >= 75)
        {
            Console.WriteLine("Grade: B");
        }
        else if (score >= 50)
        {
            Console.WriteLine("Grade: C");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }
    }
}
