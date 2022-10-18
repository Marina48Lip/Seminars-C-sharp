// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введит число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введит число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2)
{
    Console.WriteLine("Числа равны, введита два разных числа");
}
else
{
if (number1 > number2) Console.WriteLine($"Число {number1} больше числа {number2}");
if (number2 > number1) Console.WriteLine($"Число {number2} больше числа {number1}");
}