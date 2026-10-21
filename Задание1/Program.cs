using System;

class Program
{
    static int SummaCifr(int chislo)
    {
        if (chislo == 0)
        {
            return 0;
        }
        return chislo % 10 + SummaCifr(chislo / 10);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Задание 1. Сумма цифр натурального числа");
        Console.Write("Введите натуральное число: ");
        int chislo = int.Parse(Console.ReadLine());
        Console.WriteLine("Сумма цифр: " + SummaCifr(chislo));

        Console.WriteLine();
        Console.WriteLine("Нажмите Enter, чтобы закрыть окно...");
        Console.ReadLine();
    }
}
