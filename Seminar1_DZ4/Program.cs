   // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    Console.WriteLine("Введите число: ");
 int n = Convert.ToInt32(Console.ReadLine());
 int number = 1;
 Console.Write($"Четные числа от 1 до {n}: ");
        while (number <= n)
        {
            if (number % 2 == 0) Console.Write($"{number} ");
            number = number + 1;
        }
        