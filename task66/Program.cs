/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
		Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = SumOfNumbers(m, n);

        Console.WriteLine("Сумма натуральных чисел от {0} до {1}: {2}", m, n, sum);

        Console.ReadLine();
    }

    static int SumOfNumbers(int m, int n)
    {
        if (m > n)
            return 0;

        if (m <= 0)
            return SumOfNumbers(m + 1, n);

        return m + SumOfNumbers(m + 1, n);
    }
}

