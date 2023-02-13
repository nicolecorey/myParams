using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine(" How many random integer numbers would you like to generate?");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];
        Random r = new Random();

        for (int i = 0; i < size; i++)
        {
            numbers[i] = r.Next(1, 10);
        }
        foreach (int i in numbers)
        {
            Console.WriteLine(i);

        }

        Console.WriteLine($"Added total of the numbers array={Add(numbers)}");
        Console.WriteLine($"Multiplied total of the numbers array={Multiply(numbers)}");
    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }

}