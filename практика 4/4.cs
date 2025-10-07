using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 1");
        // Задание 1
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();
        string resultString = "";

        for (int i = 0; i < inputString.Length; i++)
        {
            if (i % 2 == 0) 
            {
                resultString += char.ToUpper(inputString[i]);
            }
            else 
            {
                resultString += char.ToLower(inputString[i]);
            }
        }
        Console.WriteLine("Результат: " + resultString);

        Console.WriteLine("\nЗАДАНИЕ 2");
        // Задание 2
        Console.Write("Введите число (до 1000): ");
        int number = int.Parse(Console.ReadLine());

        if (number > 1000)
        {
            Console.WriteLine("Число должно быть не больше 1000!");
        }
        else
        {
            for (int i = 0; i <= number; i++)
            {
                Console.Write(i);
                if (i < number) Console.Write(" "); 
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nЗАДАНИЕ 3");
        // Задание 3
        int[] numbers = new int[5];

        Console.WriteLine("Введите 5 чисел:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Массив в обратном порядке: ");
        for (int i = 4; i >= 0; i--)
        {
            Console.Write(numbers[i]);
            if (i > 0) Console.Write(" ");
        }
        Console.WriteLine();
    }
}