//Напишите программу, которая принимает на вход два числа и вычисляет не является ли одно квадратом другого
Console.WriteLine("Введит число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введит число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2*number2)
{ 
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не является квадратом числа {number2}");
}
if(number2 == number1*number1)
{
    Console.WriteLine($"Число {number2} является квадратом числа {number1}");
}
else
{
   Console.WriteLine($"Число {number2} не является квадратом числа {number1}"); 
}