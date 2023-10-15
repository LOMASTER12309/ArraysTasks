using System;
using System.IO;
namespace ArraysTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну первого массива: ");
            int n1 = protect_int_input();
            Random rnd = new Random();
            int[] mas1 = new int[n1];
            Console.Write("Первый массив: ");
            for (int i = 0; i < n1; i++)
            {
                mas1[i] = rnd.Next(100);
                Console.Write(mas1[i] + " ");
            }
            Console.Write("\nВведите длинну второго массива: ");
            int n2 = protect_int_input();
            int[] mas2 = new int[n2];
            Console.Write("Второй массив: ");
            for (int i = 0; i < n2; i++)
            {
                mas2[i] = rnd.Next(100);
                Console.Write(mas2[i] + " ");
            }
            Console.Write("Введите позицию K = ");
            int k = protect_int_input() - 1;
            Array.Resize<int>(ref mas1, mas1.Length + mas2.Length);
            Array.Copy(mas1, k, mas1, k + mas2.Length, mas1.Length - mas2.Length - k);
            Array.Copy(mas2, 0, mas1, k, mas2.Length);
            Console.Write("Результат: ");
            for (int i = 0; i < mas1.Length; i++)
                Console.Write(mas1[i] + " ");
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
