// Задача N3 Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

void MultiplicationOfArrays(int[,] array3, int[,] array4)
{
    int[,] array5 = new int[4, 4];
    for (int i = 0; i < array5.GetLength(0); i++)
    {
        for (int j = 0; j < array5.GetLength(1); j++)
        {
            array5[i, j] = array3[i, j] * array4[i, j];
        }
    }
    for (int i = 0; i < array5.GetLength(0); i++)
    {
        for (int j = 0; j < array5.GetLength(1); j++)
        {
            Console.Write($"{array5[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] array = new int[4, 4];
int[,] array6 = new int[4, 4];  
FillArray(array);
FillArray(array6);
PrintArray(array);
Console.WriteLine("   *   ");
PrintArray(array6);
Console.WriteLine("   =   ");
MultiplicationOfArrays(array, array6);