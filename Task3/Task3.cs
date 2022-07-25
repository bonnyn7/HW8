//Задайте две матрицы. Напишите программу, которая выведет матрицу произведения элементов двух предыдущих матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

using System;

namespace Homework8
{
    class Task3
    {
        static int[,] firstArray = {{1, 4, 7, 2},
                                 {5, 9, 2, 3},
                                 {8, 4, 2, 4},
                                 {5, 2, 6, 7}};
        static int[,] secondArray = {{1, 5, 8, 5},
                                 {4, 9, 4, 2},
                                 {7, 2, 2, 6},
                                 {2, 3, 4, 7}};
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine("]");
            }
        }
        static int[,] IncreaseArray (int[,] firstArray, int[,] secondArray)
        {
            int rows, columns;
            if (firstArray.GetLength(0) <= secondArray.GetLength(0)) rows = firstArray.GetLength(0);
            else rows = secondArray.GetLength(0);
            if (firstArray.GetLength(1) <= secondArray.GetLength(1)) columns = firstArray.GetLength(1);
            else columns = secondArray.GetLength(1);

            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = firstArray[i, j] * secondArray[i, j];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Первый массив:");
            PrintArray(firstArray);
            Console.WriteLine("Второй массив:");
            PrintArray(secondArray);
            Console.WriteLine("Произведение элементов двух массивов:");
            PrintArray(IncreaseArray(firstArray, secondArray));
        }
    }
}
