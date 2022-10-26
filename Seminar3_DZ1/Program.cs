﻿// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
//int a = n / 10000; 
//int a1 = n % 10;
//int b = (n / 1000) % 10;
//int b1 = (n % 100) / 10;
//Console.WriteLine($"{a}; {a1}; {b}; {b1}");

if (n / 10000 == n % 10 && (n / 1000) % 10 == (n %100) / 10)
{
    Console.WriteLine("Число N является палиндромом");
}
else
{
    Console.WriteLine("Число N не является палиндромом");
}