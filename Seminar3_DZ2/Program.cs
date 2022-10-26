// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

double GetRasst3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double rasstAB = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return rasstAB;
}

Console.Write("Введите координаты точки А: x = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" y = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" z = ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки В: x = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write(" y = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write(" z = ");
int z2 = Convert.ToInt32(Console.ReadLine());
double rasstAB = GetRasst3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между A и B равно {rasstAB}");