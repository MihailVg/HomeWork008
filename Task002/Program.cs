
// Задача N2 Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SumOfRows(int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1) - 1; j++)
        {
            array3[i, 3] += array3[i, j];
        }
    }
}

void FindMinRow(int[,] array4)
{
    int i = 0;
    int min = array4[i, 3];
    for (i = 0; i < array4.GetLength(0) - 1; i++)
    {
        if (min > array4[i + 1, 3])
        {
            min = array4[i + 1, 3];
        }
    }
    for (i = 0; i < array4.GetLength(0); i++)
    {
        if (array4[i, 3] == min)
        {
            Console.WriteLine($"Строка с наименьшей суммой элементов: {i + 1}");
        }
    }
}

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
SumOfRows(array);
Console.WriteLine();
PrintArray(array);
FindMinRow(array);
