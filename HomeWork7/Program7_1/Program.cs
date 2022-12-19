// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.


Console.Clear();

Console.Write("Задайте количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Задайте количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] arrayDouble = GetArrayDouble(rows, columns, 0, 10);
PrintArrayDouble(arrayDouble);

double[,] GetArrayDouble(int m, int n, int min, int max)
{
    double[,] result = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
          result[i, j] = new Random().NextDouble() * (max - min);
        }
    }
    return result;
}

void PrintArrayDouble(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f1}");
        }
        Console.WriteLine();
            }
}
Console.ReadLine();