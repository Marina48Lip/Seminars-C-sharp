/* Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.*/


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

//Заполнение массива

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
int[,] array = new int[3,4];

FillArray(array);
Console.WriteLine();
PrintArray(array);

Console.Write("Введите позицию М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > array.GetLength(0) || n > array.GetLength(1))
{
    Console.WriteLine("В массиве отсутствует элемент в такой позиции");
}
else Console.WriteLine(array[m - 1, n -1]); // -1, т.к. позиция в программе начинается с 0.