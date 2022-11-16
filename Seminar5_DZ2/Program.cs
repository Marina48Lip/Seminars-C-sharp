/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 25);
    Console.Write(array[i] + " ");
} 
int sumOdd = 0;

void SummaArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sumOdd = sumOdd + array[i];
    }
}
}
SummaArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов,стоящих на нечетных позициях равна {sumOdd}");