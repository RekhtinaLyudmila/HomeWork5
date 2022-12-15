//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите значение B1");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение K1");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение B2");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение K2");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b1 -b2) / (k2-k1);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых x: {x}; y: {y}");
Console.ReadLine();