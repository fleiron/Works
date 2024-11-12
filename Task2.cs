using System;
public class Task2 : ITask
{
    public void Run()
    {
        int a, b, c;

        Console.WriteLine("Введіть три сторони:");

        a = GetValidNumber("Перша сторона: ");
        b = GetValidNumber("Друга сторона: ");
        c = GetValidNumber("Третя сторона: ");

        if (IsValidTriangle(a, b, c))
        {
            double perimeter = a + b + c;
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            
            Console.WriteLine($"Периметр: {perimeter}, Площа: {area}");
            Console.WriteLine("Тип трикутника: " + GetTriangleType(a, b, c));
        }
        else
        {
            Console.WriteLine("Неправильний трикутник");
        }
    }
    private bool IsValidTriangle(int a, int b, int c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
    private string GetTriangleType(int a, int b, int c)
    {
        if (a == b && b == c) return "Рівносторонній";
        if (a == b || b == c || a == c) return "Рівнобедрений";
        return "Різносторонній";
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
