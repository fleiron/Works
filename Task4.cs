using System;
using System.Linq;
public class Task4 : ITask
{
    public void Run()
    {
        int lastDigit = GetValidNumber("Введіть останню цифру вашого номера (0-23): ", 0, 23);

        int arrayLength = 10 + lastDigit;
        int[] X = new int[arrayLength];
        
        Random random = new Random();
        for (int i = 0; i < arrayLength; i++)
        {
            X[i] = random.Next(-100, 101);
        }

        int M = GetValidNumber("Введіть число M: ", int.MinValue, int.MaxValue);

        int[] Y = X.Where(x => Math.Abs(x) > Math.Abs(M)).ToArray();

        Console.WriteLine("Масив X: " + string.Join(", ", X));
        Console.WriteLine($"Число M: {M}");
        Console.WriteLine("Масив Y: " + string.Join(", ", Y));
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
