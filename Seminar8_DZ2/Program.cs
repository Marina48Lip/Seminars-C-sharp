//  Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
int[] summ = new int[m];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" Сумма строки равна " + summ[i] + " ");
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
            summ[i] = summ [i] + array [i,j];
        }
         
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int min = summ[0];
int ind = 0;

for (int i = 0; i < summ.Length; i++)
    {
        if (min > summ[i])
            {
                min = summ[i];
                ind = i;
            }
    }
        
Console.WriteLine("Строка с наименьшей суммой элементов: ");


for (int j= 0; j < array.GetLength(1); j++)
{
    Console.Write(array[ind, j] + " ");
}