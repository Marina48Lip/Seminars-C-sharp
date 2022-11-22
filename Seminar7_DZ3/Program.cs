/*Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для поиска ср. арифметического значения каждого столбца.*/

Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i, j] + " ");
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

void ArifMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++) 
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
           sum = sum + array [i, j];
        }
        double average = (double)sum / array.GetLength(0);
        
        Console.WriteLine($"Среднее арифметическое {j + 1}-го столбца = {Math.Round(average, 2)}");
    }
}

FillArray(array);
Console.WriteLine();
PrintArray(array);
ArifMean(array);