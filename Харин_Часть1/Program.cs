using System;

namespace TaskSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите номер задания:");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними");
                Console.WriteLine("2. Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел:");
                Console.WriteLine("3. Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта");
                Console.WriteLine("4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути");
                Console.WriteLine("5. Разработайте программу для нахождения самого длинного слова в предложении");
                Console.WriteLine("6. Разработайте программу, которая может перемножить два массива значений");
                Console.WriteLine("7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных");
                Console.WriteLine("8. Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем");
                Console.WriteLine("9. Выход");
                Console.WriteLine("----------------------------------------------------------------");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AverageOfFourNumbers();
                        break;
                    case "2":
                        Calculator();
                        break;
                    case "3":
                        TemperatureConverter();
                        break;
                    case "4":
                        FileNameExtractor();
                        break;
                    case "5":
                        LongestWordFinder();
                        break;
                    case "6":
                        ArrayMultiplier();
                        break;
                    case "7":
                        MinMaxFinder();
                        break;
                    case "8":
                        NumberPyramid();
                        break;
                    case "9":
                        return; // Выход из приложения
                    default:
                        Console.WriteLine("Ошибка! Неправильный номер. Введите тот, что из списка :)");
                        break;
                }
            }
        }

        static void AverageOfFourNumbers()
        {
            Console.Clear();
            Console.WriteLine("Задача 1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними");
            Console.WriteLine("");
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите четвертое число:");
            double num4 = Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"Среднее значение: {average}");

            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
            Console.ReadKey();
        }

        static void Calculator()
        {
            Console.Clear();
            Console.WriteLine("Задача 2. Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел:");
            Console.WriteLine("");
            Console.WriteLine("Введите два числа:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Вы ввели числа: {num1} и {num2}");
            Console.WriteLine("Какое действие выполнить?");
            Console.WriteLine("");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Нахождение остатка");

            int operation = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                    break;
                case 4:
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Ошибка: Деление на ноль.");
                    Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                    break;
                case 5:
                    result = num1 % num2;
                    Console.WriteLine($"Результат: {num1} % {num2} = {result}");
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции.");
                    break;
            }

            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
            Console.ReadKey();
        }

        static void TemperatureConverter()
        {
            Console.Clear();
            Console.WriteLine("Задача 3. Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта");
            Console.WriteLine("");
            Console.WriteLine("Выберите шкалу вводимой температуры:");
            Console.WriteLine("1. Цельсий");
            Console.WriteLine("2. Кельвин");
            Console.WriteLine("3. Фаренгейт");

            int scaleFrom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите показатель температуры (градусы):");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите тип шкалы для конвертации:");
            Console.WriteLine("");
            Console.WriteLine("1. Цельсий");
            Console.WriteLine("2. Кельвин");
            Console.WriteLine("3. Фаренгейт");

            int scaleTo = Convert.ToInt32(Console.ReadLine());
            double convertedTemperature = 0;

            if (scaleFrom == 1) // Цельсий
            {
                if (scaleTo == 2) // Кельвин
                    convertedTemperature = temperature + 273.15;
                else if (scaleTo == 3) // Фаренгейт
                    convertedTemperature = (temperature * 9 / 5) + 32;
            }
            else if (scaleFrom == 2) // Кельвин
            {
                if (scaleTo == 1) // Цельсий
                    convertedTemperature = temperature - 273.15;
                else if (scaleTo == 3) // Фаренгейт
                    convertedTemperature = (temperature - 273.15) * 9 / 5 + 32;
            }
            else if (scaleFrom == 3) // Фаренгейт
            {
                if (scaleTo == 1) // Цельсий
                    convertedTemperature = (temperature - 32) * 5 / 9;
                else if (scaleTo == 2) // Кельвин
                    convertedTemperature = (temperature - 32) * 5 / 9 + 273.15;
            }

            Console.WriteLine($"Результат конвертации: {convertedTemperature}");

            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
            Console.ReadKey();
        }

        static void FileNameExtractor()
        {
            Console.Clear();
            Console.WriteLine("Задача 4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути");
            Console.WriteLine("");
            Console.WriteLine("Введите путь до файла:");
            string path = Console.ReadLine();
            string fileName = System.IO.Path.GetFileName(path);
            Console.WriteLine($"Имя файла: {fileName}");
            Console.WriteLine("");
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
            Console.ReadKey();
        }

        static void LongestWordFinder()
        {
            Console.Clear();
            Console.WriteLine("Задача 5. Разработайте программу для нахождения самого длинного слова в предложении");
            Console.WriteLine("");
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            string longestWord = "";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine($"Самое длинное слово: {longestWord}");
            Console.WriteLine("");
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
            Console.ReadKey();
        }

        static void ArrayMultiplier()
        {
            Console.Clear();
            Console.WriteLine("Задача 6. Разработайте программу, которая может перемножить два массива значений");
            Console.WriteLine("");
            Console.WriteLine("Введите значения для первого массива через пробел:");
            string[] firstArrayInput = Console.ReadLine().Split(' ');
            Console.WriteLine("Введите значения для второго массива через пробел:");
            string[] secondArrayInput = Console.ReadLine().Split(' ');

            int length = Math.Min(firstArrayInput.Length, secondArrayInput.Length);
            int[] resultArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                resultArray[i] = Convert.ToInt32(firstArrayInput[i]) * Convert.ToInt32(secondArrayInput[i]);
            }

            Console.WriteLine("Результат: " + string.Join(" ", resultArray));
            Console.WriteLine("");
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
            Console.ReadKey();
        }

        static void MinMaxFinder()
        {
            Console.Clear();
            Console.WriteLine("Задача 7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных");
            Console.WriteLine("");
            Console.WriteLine("Введите пять чисел:");
            string[] numbersInput = Console.ReadLine().Split(' ');
            int[] numbers = Array.ConvertAll(numbersInput, int.Parse);

            int max = numbers[0];
            int min = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max) max = number;
                if (number < min) min = number;
            }

            Console.WriteLine($"Максимальное число: {max}");
            Console.WriteLine($"Минимальное число: {min}");
            Console.WriteLine("");
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
            Console.ReadKey();
        }

        static void NumberPyramid()
        {
            Console.Clear();
            Console.WriteLine("Задача 8. Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем");
            Console.WriteLine("");
            Console.WriteLine("Введите количество уровней пирамиды:");
            int levels = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= levels; i++)
            {
                Console.WriteLine(new string(' ', levels - i) + string.Join(" ", new int[i].Select(x => i)));
            }

            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
            Console.ReadKey();
        }
    }
}
//Console.Clear();
//Console.WriteLine("");
