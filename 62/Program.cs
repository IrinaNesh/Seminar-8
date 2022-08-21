﻿/* Задача 62: Заполните спирально массив 4 на 4.
 1 2 3 4
 12 13 14 5
 11 16 15 6
 10 9 8 7
*/

int[,] array = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

Console.WriteLine("Массив:");

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(array);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write(array[i,j] + "\t");

      else Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

