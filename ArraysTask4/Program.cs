using System;
using System.IO;

namespace ArraysTask4
{
    class Program
    {
        static int[][] ReadMatrixFromFile(string FileName)
        {
            string[] s = File.ReadAllLines(FileName);
            int[][] array = new int[s.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                string[] str = s[i].Trim().Split(' ');
                array[i] = new int[str.Length];
                for (int j = 0; j < str.Length; j++)
                    array[i][j] = int.Parse(str[j].Trim());
            }
            return array;
        }


        static void Main(string[] args)
        {
            int[][] auditorium = ReadMatrixFromFile("C:\\Users\\User\\source\\repos\\ArraysTasks\\ArraysTask4\\matrix.txt");
            int n = auditorium.Length;
            int m = auditorium[0].Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(auditorium[i][j] + " ");
                Console.WriteLine();
            }
            Console.Write("Введите количество мест, которые вы хотите забронировать: ");
            int k = protect_int_input();
            for (int i = 0; i < n; i++)
            {
                int max_place = 0;
                for (int j = 0; j < m; j++)
                {
                    if (auditorium[i][j] == 0)
                    {
                        max_place++;
                        if (max_place == k)
                        {
                            Console.WriteLine($"{i + 1}");
                            Environment.Exit(0);
                        }
                    }
                    else max_place = 0;
                }
            }
            Console.WriteLine(0);
        }
        static int protect_int_input()
        {
            int num = 0;
            while (true)
            {
                string text = Console.ReadLine();
                if (int.TryParse(text, out num)) break;
                Console.Write("Неверный формат! Попробуйте ещё: ");
            }
            return num;
        }
    }
}