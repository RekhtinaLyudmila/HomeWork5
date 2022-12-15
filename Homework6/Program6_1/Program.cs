// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа через пробел: ");
string str = Console.ReadLine();

var arrStr = str.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[] arr = Array.ConvertAll(arrStr, Convert.ToInt32);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество элементов больше нуля: {count}");
