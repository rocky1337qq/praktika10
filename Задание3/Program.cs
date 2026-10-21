using System;

class Program
{
    static int ShagiHanoi(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return 2 * ShagiHanoi(n - 1) + 1;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Задание 3. Шаги Ханойских башен");
        Console.Write("Введите количество дисков: ");
        int diski = int.Parse(Console.ReadLine());
        Console.WriteLine("Количество шагов: " + ShagiHanoi(diski));

        Console.WriteLine();
        Console.WriteLine("Нажмите Enter, чтобы закрыть окно...");
        Console.ReadLine();
    }
}
