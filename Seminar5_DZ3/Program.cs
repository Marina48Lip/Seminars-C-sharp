//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
} 

int minPosition = 0;

//нахождение минимального
void MinArray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if(array[i] < array[minPosition])
            {
                minPosition = i;
            }
    }
Console.WriteLine("");
Console.WriteLine($"Минимальный элемент {array[minPosition]}");
}

//нахождение максимального
int maxPosition = 0;
void MaxArray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if(array[i] > array[maxPosition])
            {
                maxPosition = i;
            }
    }
 Console.WriteLine($"Максимальный элемент {array[maxPosition]}");
 Console.WriteLine("");
 }

MinArray(array);
MaxArray(array);
Console.WriteLine($"Разница {array[maxPosition]-array[minPosition]}");

 
