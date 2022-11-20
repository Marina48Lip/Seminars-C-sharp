// Напишите программу, которая принимает на вход два числа (А и В) 
// и возводит число А в натуральную степень В, используя цикл.


Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;
for (int i = 1; i < b; i++)
{
   step = step*a; 
}
Console.WriteLine($"Число А в степени В равно {step}");