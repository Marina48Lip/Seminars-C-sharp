// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int[M];
for (int i = 0; i < M; i++)
{
    Console.WriteLine($"Введите число под номером {i + 1}");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int count = 0;
for (int i = 0; i < M; i++)
{
    if (array[i] > 0) count = count + 1;
}
Console.Write($"Вы ввели {count} числа больше 0");