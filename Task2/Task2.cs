// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;

namespace Homework8
{
    class Task2
    {
         static void Main(string[] args)
        {
            Console.Write("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int [,] array = new int [m,n];
            int[]sumArray= new int[array.GetLength(0)];

            RandomArray (array, m, n);
            PrintArray (array);
            ArrayRowSum (array,sumArray);
            Console.WriteLine("Номер строки с наименьшей суммой элементов: {0} строка", 
            SearchMinElement(ArrayRowSum(array,sumArray)) + 1);
        }
        static void RandomArray (int [,] array, int m, int n)
        {
            Random random = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(10);
                }
            }
            Console.Write("Исходный массив: ");
            Console.WriteLine();
        }
        public static void PrintArray(int[,] array)
        {
            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    Console.Write(array[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[] ArrayRowSum(int[,] array, int[] sumArray)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    sumArray[i] += array[i,j];
                }
            }
            return sumArray;
        }
        static int SearchMinElement(int[] array)
        {
            int min_index = -1;
            if (array.Length > 0)
                min_index = 0;
                if (array.Length > 1) 
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[min_index] > array[i]) min_index = i;
                    }
            return min_index;
        }
    }
}