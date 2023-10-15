using System;

namespace ArraysTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива: ");
            int n = protect_int_input();
            Console.Write("Ввести массив вручную или случайно (введите 1 или 2): ");
            int mode = protect_int_input();
            int[] mas = new int[n];
            switch (mode)
            {
                case 1:
                    Random rnd = new Random();
                    Console.Write("Первый массив: ");
                    for (int i = 0; i < n; i++)
                    {
                        mas[i] = rnd.Next(100);
                        Console.Write(mas[i] + " ");
                    }
                    break;
                case 2:
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("mas[" + i + "] = ");
                        mas[i] = protect_int_input();
                    }
                    Console.Write("Ваш массив: ");
                    foreach (var item in mas)
                    {
                        Console.Write(item + " ");
                    }
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            int parity = n % 2;//чётность
            Array.Resize<int>(ref mas, n + n / 2);
            Array.Copy(mas, 0, mas, n, n / 2);
            Array.Copy(mas, n / 2, mas, 0, n / 2 + parity);
            Array.Copy(mas, n, mas, n / 2 + parity, n / 2);
            Array.Resize<int>(ref mas, n);
            Console.Write("\nРезультат: ");
            foreach (var item in mas)
            {
                Console.Write(item + " ");
            }
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
