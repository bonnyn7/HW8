//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

using System;

namespace Homework8
{
    class Task1
    {
        static int[,] NewArray(int i, int j)
        {
            int[,] array = new int[i, j];
            Random random = new Random();
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    array[a, b] = random.Next(0, 9);
                }
            }
            return array;
        }
        public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
        {
            for (int k = 0; k < source.Length; k++)
            {
                if (isRow)
                    dest[dim, k] = source[k];
                else
                    dest[k, dim] = source[k];
            }
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
        static void BubbleSort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] > inArray[j + 1])
                    {
                        int temp = inArray[j];
                        inArray[j] = inArray[j + 1];
                        inArray[j + 1] = temp;
                    }
                }
        }
     static void Main(string[] args)
        {
            int colCount = 3;
            int rowCount = 4;
            int[,] array = NewArray(rowCount, colCount);
            Console.WriteLine("Исходный массив: ");
            PrintArray(array);
            Console.WriteLine("Сортировка по строкам: ");
            int[] row = new int[colCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                    row[j] = array[i, j];
                BubbleSort(row);
                Insert(true, i, row, array);
            }
            PrintArray(array);
        }
    }
}


