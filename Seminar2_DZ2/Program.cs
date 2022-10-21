// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//int a = (number - (number%10)); 
if ((number / 100) < 1)
{
    Console.WriteLine("В заданном числе третьей цифры нет");
    return;
}
while (number > 999)
{
    number = number / 10;
}
Console.WriteLine(number % 10);