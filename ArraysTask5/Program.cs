using System;
using System.IO;

namespace ArraysTask5
{
    class Program
    {
        static void ReadTwoMatrixFromFile(string FileName, out int[] matrix1, out int[] matrix2, out int rank)
        {
            string[] s = File.ReadAllLines(FileName);
            rank = s.Length / 2;
            matrix1 = new int[(int)Math.Pow(s.Length / 2, 2)];
            matrix2 = new int[(int)Math.Pow(s.Length / 2, 2)];
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < rank; i++)
            {
                string[] str1 = s[i].Trim().Split(' ');
                string[] str2 = s[i + rank + 1].Trim().Split(' ');
                for (int j = 0; j < rank; j++)
                {
                    matrix1[count1] = int.Parse(str1[j].Trim());
                    count1++;
                }
                for (int j = 0; j < rank; j++)
                {
                    matrix2[count2] = int.Parse(str2[j].Trim());
                    count2++;
                }
            }
        }
        static void Main(string[] args)
        {
            int rank = 100;
            int[] matrix1 = new int[rank * rank];
            int[] matrix2 = new int[rank * rank];
            ReadTwoMatrixFromFile("C:\\Users\\User\\source\\repos\\ArraysTasks\\ArraysTask5\\matrices.txt", out matrix1, out matrix2, out rank);
            int count = 0;
            for (int i = 0; i < rank; i++)
            {
                for (int j = 0; j < rank; j++)
                {
                    Console.Write(matrix1[count] + " ");
                    count++;
                }
                Console.WriteLine();
            }
            count = 0;
            Console.WriteLine();
            for (int i = 0; i < rank; i++)
            {
                for (int j = 0; j < rank; j++)
                {
                    Console.Write(matrix2[count] + " ");
                    count++;
                }
                Console.WriteLine();
            }
            int[] matrix3 = new int[rank * rank];
            for (int i = 0; i < rank; i++)
                for (int j = 0; j < rank; j++)
                    for (int k = 0; k < rank; k++)
                        matrix3[i * rank + j] += matrix1[i * rank + k] * matrix2[j + rank * k];
            Console.WriteLine("Результат: ");
            count = 0;
            for (int i = 0; i < rank; i++)
            {
                for (int j = 0; j < rank; j++)
                {
                    Console.Write(matrix3[count] + " ");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}