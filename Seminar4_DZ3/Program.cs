//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//  Заполнение массива производит пользователь.

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите элемент массива под номером {i}" );
   array[i] = Convert.ToInt32(Console.ReadLine());

}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
}