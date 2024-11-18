// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            // вводим данные
            Console.Write("ВВЕДИТЕ СУММУ ВКЛАДА: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("ВВЕДИТЕ СРОК ДЕЙСТВИЯ ВКЛАДА(кол-во месяцев): ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("ВВЕДИТЕ ПРОЦЕНТ ГОДОВЫХ ПО ВКЛАДУ: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a > 0 && b > 0 || b < 12)
            {
                // расчёт процента
                double monthlyInterestRate = c / 100 / 12;

                // сумма вклада
                double totalAmount = a;
                for (int month = 1; month <= b; month++)
                {
                    totalAmount += totalAmount * monthlyInterestRate;
                }
                double interestEarned = totalAmount - a;

                // результат
                Console.WriteLine("");
                Console.WriteLine($"Итак, в конце срока вклада вам начислится: {interestEarned:F2}");
                Console.WriteLine($"Сумма вклада с процентами: {totalAmount:F2}");
            }
            else if(a < 0 && b < 0 || b > 12)
            {
                Console.WriteLine("");
                Console.WriteLine("Ошибка! Введены неверные значения про сумму или срок. Нажмите любую клавишу, чтобы вернуться.");
            }
        }
    }
}

