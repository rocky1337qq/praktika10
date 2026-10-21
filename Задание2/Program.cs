 using System;

class Program
{
    static int Nod(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        return Nod(b, a % b);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Задание 2. Наибольший общий делитель");
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Нод(" + a + "; " + b + ") = " + Nod(a, b));

        Console.WriteLine();
        Console.WriteLine("Нажмите Enter, чтобы закрыть окно...");
        Console.ReadLine();
    }
}
