// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1;
for (int i = 1; i < num2; i++)
{
    result = result * num1;
}
Console.WriteLine(result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (num > 0)
{
   sum = sum + num % 10;
   num = num / 10;
}
Console.WriteLine("Сумма цифр " + sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = new int [8];
for(int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(10, 30);
    Console.WriteLine (array[i]);
}