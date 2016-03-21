using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;

            SimpleCalculator sc = new SimpleCalculator();
            Console.WriteLine("Вводите слагаемые через запятую! Используйте только целые числа!\n" +
                              "При вводе большего количества чисел учитываться будут первые два!\n" +
                              "Для выхода из программы нажмите Esq");
            while (true)
            {
                try
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Escape) break;
                    int sum = sc.AddOfTwoNumbers(Console.ReadLine());
                    Console.WriteLine(sum);

                }


                catch
                {
                    Console.WriteLine("Используйте только целые числа! \n" +
                                      "Обязательно вводите их через запятую!");
                }
            }
        }


    }
}
