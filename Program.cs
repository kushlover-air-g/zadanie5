using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер цифры последовательности:");
            int k = Convert.ToInt32(Console.ReadLine());
            int kolichestvo = 0, nomer = 0;
            double rez;
            for(int i = 0; kolichestvo<k; i++)
            {
                nomer = i;
                kolichestvo = (int)Math.Log10(nomer) + 1;
            }
            rez = nomer / Math.Pow(10, kolichestvo - k) % 10;
            Console.WriteLine(rez);
        }
    }
}
