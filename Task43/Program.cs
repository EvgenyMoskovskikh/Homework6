// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine()!);
int x = (b2 - b1) / (k1 - k2);
int y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");