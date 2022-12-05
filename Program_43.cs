// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Введите число b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "");

int X = FindX(b1, k1, b2, k2);
int Y = FindY(X, k1, b1);

Console.WriteLine($"при b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} X = {X}, Y = {Y} ");

int FindX(int b1, int k1, int b2, int k2)
{
    int X = (b2-b1) / (k1 - k2);
    return X;
}

int FindY(int X, int k1, int b1)
{
    int Y = k1 * X + b1;
    return Y;
}
