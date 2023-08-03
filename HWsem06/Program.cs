// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите M чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [M];

void Fill(int[] numbers)
{
   int n = numbers.Length;
   int i = 0;
   while (i < n)
   {
       numbers[i] = new Random().Next(0, 15);
       i++;
   }
}

void Print(int[] nums)
{
   int n = nums.Length;
   int i = 0;
   while (i < n)
   {
       Console.Write(nums[i] + " ");
       i++;
   }
   Console.WriteLine();
}

int Summ(int [] nums)
{
    int i = 0;
    int sum = 0;
    while (i < nums.Length)
    {
        if(nums[i] > 0)
        sum++;
        i++;
    }
    return sum;
}
Fill(numbers);
Print(numbers);

Console.Write($"Чисел больше нуля: {Summ(numbers)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения прямых с координатами X: {x}, Y: {y}");