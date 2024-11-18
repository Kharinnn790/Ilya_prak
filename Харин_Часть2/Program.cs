// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // Проходим по строкам от 1 до 9
        for (int i = 1; i <= 9; i++)
        {
            // Проходим по столбцам от 1 до 9
            for (int j = 1; j <= 9; j++)
            {
                // Выводим текущую операцию умножения
                Console.Write($"{i} x {j} = {i * j}\t");
            }
            // Переход на новую строку после завершения строки таблицы
            Console.WriteLine();
        }
    }
}

