//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
var random = new Random();

int[,] array = GetArray(random.Next(3,10), random.Next(3,10), 0, 10);
PrintArray(array);
Console.Write("Задайте количество строк  массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Задайте количество столбцов  массива: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Задайте элемент массива: ");
int el = int.Parse(Console.ReadLine());
if(FindElement(array, el, out int column , out int row))
{
    Console.WriteLine($"Элемент найден column = {column} row = {row}");
} 
else
{
   Console.WriteLine("Элемент не найден"); 
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}");
        }
        Console.WriteLine();
    }
}

static bool FindElement(int[,] array, int el, out int colum, out int rows)
{
    colum = 0;
    rows = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i , j] == el) {
                colum = j;
                rows = i;
                return true;
            }
        }
    }
    return false;
}