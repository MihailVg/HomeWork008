// Задача N1 Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortArray(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int y = 0; y < array2.GetLength(1); y++)
        {
            for (int j = 0; j < array2.GetLength(1) - 1; j++)
            {
                if (array2[i, j] < array2[i, j + 1])
                {
                    int x = array2[i, j + 1];
                    array2[i, j + 1] = array2[i, j];
                    array2[i, j] = x;
                }
            }
        }

    }
}

int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
SortArray(array);

Console.WriteLine();

PrintArray(array);


