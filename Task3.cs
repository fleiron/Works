using System;
public class Task3 : ITask
{
    public void Run()
    {
        int lastDigit = GetValidNumber("Введіть останню цифру вашого номера (0-23): ", 0, 23);

        int arrayLength = 10 + lastDigit;
        int[] array = new int[arrayLength];

        Random random = new Random();
        
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = random.Next(1, 101);
        }

        int minValue = int.MaxValue;
        int maxValue = int.MinValue;

        foreach (int number in array)
        {
            if (number < minValue) minValue = number;
            if (number > maxValue) maxValue = number;
        }

        Console.WriteLine("Масив: " + string.Join(", ", array));
        Console.WriteLine($"Мінімальне значення: {minValue}");
        Console.WriteLine($"Максимальне значення: {maxValue}");
    }
    private int GetValidNumber(string prompt, int minValue, int maxValue)
    {
        int number;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out number) || number < minValue || number > maxValue)
        {
            Console.WriteLine($"Неправильне введення. Будь ласка, введіть число від {minValue} до {maxValue}:");
        }
        return number;
    }
}
