// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

double[,] numbers = new double[4,5];
for (int i = 0; i < 4; i++)
{
   for (int j = 0; j < 5; j++)
   { 
       numbers[i, j] = Convert.ToDouble(new Random().Next(1, 15)) / 10;
       Console.Write(numbers[i, j] + " ");
   }
   Console.WriteLine();
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите строку ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец ");
int col = Convert.ToInt32(Console.ReadLine());


int[,] numbers = new int[4,5];
for (int i = 0; i < 4; i++)
{
   for (int j = 0; j < 5; j++)
   { 
       numbers[i, j] = new Random().Next(1, 15);
       Console.Write(numbers[i, j] + " ");
   }
   Console.WriteLine();
}
int rows = numbers.GetLength(0);
int cols = numbers.GetLength(1);
if(row>= 0 && row < rows && col >= 0 && col < cols)
{
    int element = numbers[row, col];
    Console.WriteLine("Значение элемента " + element);
}else
{
    Console.WriteLine("Такого элемента не существует");
}

// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] numbers = new int[4,5];
for (int i = 0; i < numbers.GetLength(0); i++)
{
   for (int j = 0; j < numbers.GetLength(1); j++)
   { 
       numbers[i, j] = new Random().Next(1, 15);
       Console.Write(numbers[i, j] + " ");
   }
   Console.WriteLine();
}
for(int j = 0; j < numbers.GetLength(1); j++ )
{
    double sum = 0;
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        sum += numbers[i, j];
    }
    Console.Write($"{sum/numbers.GetLength(0)} ");
}
