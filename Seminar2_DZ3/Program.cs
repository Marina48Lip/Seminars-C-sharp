// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру дня недели: ");
int numberWeek = Convert.ToInt32(Console.ReadLine());
if(numberWeek > 7 || numberWeek <1)
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
    if (numberWeek == 1 || numberWeek == 2 || numberWeek == 3
    || numberWeek == 4 || numberWeek == 5)
    Console.WriteLine("Рабочий день");
    if (numberWeek == 6 || numberWeek == 7)
    Console.WriteLine("Выходной день");
}