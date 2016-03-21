using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_03
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;

            SimpleCalculator sc = new SimpleCalculator();
            Console.WriteLine("Вводите слагаемые через следующие символы:\n" +
                              "',' '.' '_' '*' '&' '^' '%' '$' '#' '@' '!' '~' или пробел!\n" +
                              "Используйте только целые числа!\n" +
                              " Для выхода из программы нажмите Esq");
            while (true)
            {
                try
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Escape) break;
                    int sum = sc.AddOfSomeNumbers(Console.ReadLine());
                    Console.WriteLine(sum);

                }


                catch
                {
                    Console.WriteLine("Используйте только целые числа! \n" +
                                      "Вводите их через вышеуказынные символы!");
                }
            }
        }


    }
}