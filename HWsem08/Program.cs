// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] numbers = new int[5, 5];
for (int i = 0; i < numbers.GetLength(0); i++)
{
   for (int j = 0; j < numbers.GetLength(1); j++)
   {
       numbers[i, j] = new Random().Next(1, 15);

   }

}

void Print (int[,] numbers)
{
   for(int i = 0; i < numbers.GetLength(0); i++)
   {
       for(int j = 0; j < numbers.GetLength(1); j++)
       {
           Console.Write(numbers[i, j] + " ");
       }
       Console.WriteLine();
   }

}
Print(numbers);
Console.WriteLine();
void Sorting(int [,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < nums.GetLength(1) - 1; k++)
        {
            if (nums[i, k] < nums[i, k + 1]) 
            {
                
                int temp = nums[i, k];
                nums[i, k] = nums[i, k + 1];
                nums[i, k + 1] = temp;
            }
        }
    }
}
}
Sorting(numbers);
Print(numbers);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int row = 0;
int minsum = Int32.MaxValue;
int[,] numbers = new int[3, 3];
for (int i = 0; i < numbers.GetLength(0); i++)
{
   for (int j = 0; j < numbers.GetLength(1); j++)
   {
       numbers[i, j] = new Random().Next(1, 15);

   }

}

void Print (int[,] numbers)
{
   for(int i = 0; i < numbers.GetLength(0); i++)
   {
       for(int j = 0; j < numbers.GetLength(1); j++)
       {
           Console.Write(numbers[i, j] + " ");
       }
       Console.WriteLine();
   }

}
Print(numbers);
Console.WriteLine();

void Summ(int [,] numbers)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
   {
    int sum = 0;
       for(int j = 0; j < numbers.GetLength(1); j++)
       {
           sum  = sum + numbers[i, j];
       }
       if(sum<minsum)
       {
        minsum = sum;
        row++;
       }
       
   }

}
Summ(numbers);
Console.WriteLine($"Строка {row} с наименьшей суммой {minsum}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrixA = new int[2, 2];
for (int i = 0; i < matrixA.GetLength(0); i++)
{
   for (int j = 0; j < matrixA.GetLength(1); j++)
   {
       matrixA[i, j] = new Random().Next(1, 15);

   }

}

void Print (int[,] matrixA)
{
   for(int i = 0; i < matrixA.GetLength(0); i++)
   {
       for(int j = 0; j < matrixA.GetLength(1); j++)
       {
           Console.Write(matrixA[i, j] + " ");
       }
       Console.WriteLine();
   }

}
Print (matrixA);
Console.WriteLine ();

int[,] matrixB = new int[3, 3];
for (int i = 0; i < matrixB.GetLength(0); i++)
{
   for (int j = 0; j < matrixB.GetLength(1); j++)
   {
       matrixB[i, j] = new Random().Next(1, 15);

   }

}

void Print1 (int[,] matrixB)
{
   for(int i = 0; i < matrixB.GetLength(0); i++)
   {
       for(int j = 0; j < matrixB.GetLength(1); j++)
       {
           Console.Write(matrixB[i, j] + " ");
       }
       Console.WriteLine();
   }

}
Print1(matrixB);
Console.WriteLine ();

int rowsA = matrixA.GetLength(0);
int colsA = matrixA.GetLength(1);
int rowsB = matrixB.GetLength(0);
int colsB = matrixB.GetLength(1);

int [,] matrixC = new int[rowsA, colsB];

for(int i = 0; i < rowsA; i++)
{
    for(int j = 0; j < colsB; j++)
    {
        for(int k = 0; k < colsA; k++)
        {
            matrixC[i,j] +=  matrixA[i,k] * matrixB[k,j];
        }
    }
} 
Console.WriteLine("Произведение матриц: ");

void Print2 (int[,] matrixC)
{
   for(int i = 0; i < rowsA; i++)
   {
       for(int j = 0; j < colsB; j++)
       {
           Console.Write(matrixC[i, j] + " ");
       }
       Console.WriteLine();
   }

}
Print2(matrixC);