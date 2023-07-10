/* Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.

1, 2, 3

4, 6, 1

2, 1, 6

1 встречается 3 раза

2 встречается 2 раз

3 встречается 1 раз

4 встречается 1 раз

6 встречается 2 раза */

Console.Write("Введите число строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int coloumns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, coloumns, 0, 10);
PrintArray(array);
Console.WriteLine("Введите искомое число: ");
int element = int.Parse(Console.ReadLine()!);
int result = GetCountOfElements(element, array);
Console.WriteLine($"{element} встречается {result} раз ");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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
            Console.Write($"{inArray[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int GetCountOfElements(int el, int[,] inArray)
{
    int count = 0;
    int[,] result = new int[10, 2];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] == element)
            {
                count++;
            }
        }
    }
    return count;
}