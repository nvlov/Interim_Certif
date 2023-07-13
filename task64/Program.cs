/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
		Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine()!);

        PrintNumbers(n);

        Console.ReadLine();
    }

    static void PrintNumbers(int n)
    {
        if (n < 1)
            return;

        if (n != 1)
            Console.Write(n + ", ");
        else
            Console.Write(n);

        PrintNumbers(n - 1);
    }
}
