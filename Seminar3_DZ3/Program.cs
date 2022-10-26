//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void printCubeToConsole(int n)
{
    for (int count = 1; count <= n; count++)
    {
               Console.WriteLine(count*count*count);
    }
}
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
printCubeToConsole(n);
