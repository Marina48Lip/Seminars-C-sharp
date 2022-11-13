// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Для решения задания использование цикла for является обязательным условием
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string strNumber = Math.Abs(number).ToString();
int sum = 0;
int Length = strNumber.Length;

for (int i = 0; i < Length; i++)
{
    int num = Convert.ToInt32(strNumber[i].ToString());
   sum = sum + num;
}
Console.WriteLine(sum);