using System;
using System.Collections.Generic;

namespace ArraysTask3
{
    class Program
    {
        static int[] InitializeRandMas(int size)
        {
            Random rand = new Random();
            int[] mas = new int[size];
            for (int i = 0; i < size; i++)
                mas[i] = rand.Next(100);
            return mas;
        }
        static int[] SumMas(int[] arr1, int[] arr2) //прибавляем второй к первому
        {
            if (arr1.Length == arr2.Length)
            {
                int[] mas = new int[arr1.Length];
                for (int i = 0; i < arr1.Length; i++)
                    mas[i] = arr1[i] + arr2[i];
                return mas;
            }
            else return null;
        }
        static void PrintMas(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Массив пуст!");
                return;
            }
            foreach (var obj in arr)
                Console.Write(obj + " ");
            Console.WriteLine();
        }
        static void MultiplyByNumber(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= num;
            }
        }
        static int[] IntersectionMas(int[] arr1, int[] arr2)
        {
            if ((arr1.Length == 0) || (arr2.Length == 0)) return null;
            List<int> common = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
                if (Array.IndexOf<int>(arr2, arr1[i]) != -1)
                    if (Array.IndexOf<int>(arr1, arr1[i]) == i)
                        common.Add(arr1[i]);
            return common.ToArray();
        }
        static void SortInDesc(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int k = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] < k)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = k;
            }
        }
        static object min(int[] arr)
        {
            if (arr.Length == 0) return Int32.MinValue;
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (min > arr[i]) min = arr[i];
            return min;
        }

        static object max(int[] arr)
        {
            if (arr.Length == 0) return Int32.MaxValue;
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (max < arr[i]) max = arr[i];
            return max;
        }

        static void Main(string[] args)
        {
            int[] mas3 = new int[] { };
            int[] mas1 = InitializeRandMas(20);
            PrintMas(mas1);
            int[] mas2 = InitializeRandMas(20);
            PrintMas(mas2);
            PrintMas(IntersectionMas(mas1, mas2));
        }
    }
}