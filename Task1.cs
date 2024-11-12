using System;
public class Task1 : ITask
{
    public void Run()
    {
        int lowerLimit = 1;
        int n;

        Console.Write("Введіть значення n: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Неправильне введення. Будь ласка, введіть ціле число для n:");
        }

        int upperLimit = 10 + n;
        
        Console.WriteLine("Введіть три числа:");

        int num1 = GetValidNumber("Перше число: ");
        int num2 = GetValidNumber("Друге число: ");
        int num3 = GetValidNumber("Третє число: ");
        
        Console.WriteLine($"\nЧисла, що належать інтервалу [{lowerLimit}, {upperLimit}]:");

        if (num1 >= lowerLimit && num1 <= upperLimit)
            Console.WriteLine(num1);
        if (num2 >= lowerLimit && num2 <= upperLimit)
            Console.WriteLine(num2);
        if (num3 >= lowerLimit && num3 <= upperLimit)
            Console.WriteLine(num3);
    }
    private int GetValidNumber(string prompt)
    {
        int number;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Неправильне введення. Будь ласка, введіть ціле число:");
        }
        return number;
    }
}
