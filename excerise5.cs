using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int square = Square(number);
        Console.WriteLine($"The square of {number} is {square}");
    }

    static int Square(int x)
    {
        return x * x;
    }
}
