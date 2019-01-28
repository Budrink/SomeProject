using System;

namespace CalcProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите выражение: ");
                    Console.WriteLine(ReversPolishNotation.Calculate(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
            }
        }
    }
}
