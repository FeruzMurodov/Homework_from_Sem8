/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Write("Введите число строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int coloumns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, coloumns, 0, 10);
PrintArray(array);
Console.WriteLine();
SortBySize(array);
PrintArray(array);

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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortBySize(int[,] inArray)
{
    for (int k = 0; k < inArray.GetLength(0); k++)
    {
        for (int i = 0; i < inArray.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < inArray.GetLength(1); j++)
            {
                int max = inArray[k, i];
                int maxIndex = i;
                int temp = 0;
                if (inArray[k, j] > max)
                {
                    max = inArray[k, j];
                    temp = inArray[k, i];
                    inArray[k, i] = inArray[k, j];
                    inArray[k, j] = temp;
                }
            }
        }
    }
}