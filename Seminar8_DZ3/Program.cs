// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/* Произведение двух матриц АВ имеет смысл только в том случае, 
когда число столбцов матрицы А совпадает с числом строк матрицы В */


Console.Write("Введите число строк 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 1-й матрицы и число строк 2-й матрицы: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 2-й матрицы: ");
int o = Convert.ToInt32(Console.ReadLine());


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void MultiplyMatrix(int[,] array1, int[,] array2, int[,] array3)
{
  for (int i = 0; i < array3.GetLength(0); i++)
  {
    for (int j = 0; j < array3.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      array3[i,j] = sum;
    }
  }
}

int[,] array1 = new int[m, n];
int[,] array2 = new int[n, o];
int[,] array3 = new int[m, o];

FillArray(array1);
FillArray(array2);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
MultiplyMatrix(array1, array2, array3);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц :");
PrintArray(array3);


