/* Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.*/

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int NumbersRec(int n)
{
    if (n == 1) return 1;
    Console.Write (n + ", ");
    return NumbersRec(n - 1);
}

Console.WriteLine(NumbersRec(n)); 