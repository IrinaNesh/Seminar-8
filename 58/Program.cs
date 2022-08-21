// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrix1 = GetArray();
int[,] matrix2 = GetArray();
int[,] resMatrix = new int[4, 4];
Console.WriteLine("Первая матрица: ");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(matrix2);
Console.WriteLine("\nПроизведение матриц: ");


for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix2.GetLength(0); k++)
        {
            resMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
        }
        Console.Write(resMatrix[i,j] + "\t");
    }
    Console.WriteLine();
}

int[,] GetArray()
{
    int[,] array = new int[4, 4];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
