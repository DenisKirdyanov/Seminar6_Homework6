// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



Console.WriteLine("Введите параметры уравнения 1 прямой: y = k1 * x + b1");
int k1 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите параметры уравнения 2 прямой: y = k2 * x + b2");
int k2 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());

void Search(double locK1, double locB1, double locK2, double locB2)
{
    double x, y;
    x = (locB2 - locB1) / (locK1 - locK2);
    y = locK1 * ((locB2 - locB1) / (locK1 - locK2)) + locB1;
    Console.WriteLine($"координаты точки пересечения: ({x}; {y})");
}

Search(k1, b1, k2, b2);