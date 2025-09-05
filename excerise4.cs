using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>();

        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Mango");

        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
