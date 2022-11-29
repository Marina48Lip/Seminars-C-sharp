/* Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.*/

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumRec(int m, int n)
{
 if (m == n) return m;
 else 
    if (m > n) return n + SumRec(m, n + 1);
    else 
      return m + SumRec(m + 1, n);
}

Console.WriteLine($"Сумма чисел в промежутке от M до N равна: {SumRec(m, n)}"); 

