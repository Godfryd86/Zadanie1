using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczydło
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Title = "Liczydło 0.1";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Witaj. Co chcesz policzyć? (wciśnij cyfrę odpowiadającą działaniu)");
                Console.WriteLine("1. Potęga");
                Console.WriteLine("2. Silnia");
                Console.WriteLine("3. Pole i Obwód Koła");
                Console.WriteLine("4. Zapisać liczbę w systemie binarnym (dwójkowym)");
                Console.WriteLine("5. Pacz Nołtsy");
                Console.WriteLine("6. Wyjdź");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); Potega(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); WBudowie(); break;
                    case ConsoleKey.D3:
                        Console.Clear(); WBudowie(); break;
                    case ConsoleKey.D4:
                        Console.Clear(); WBudowie(); break;
                    case ConsoleKey.D5:
                        Console.Clear(); Console.WriteLine("ver0.1 Menu działa. Z początku zacząłem pisać pod każdy klawisz osobny kod zanim przypomniałem sobie o caesach.");
                        Console.WriteLine("A opcja exit to juz totalna zrzynka z yt ");
                        Console.WriteLine("bo szukałem na stronie microsoftu i nie mogłem znaleźć");
                        Console.WriteLine("a wujek google pomógł w sekundę i kilka godzin babrania się załatwiłem w 5 min"); Console.ReadKey(); break;
                    case ConsoleKey.D6:
                        Environment.Exit(0); break;
                    default: break;
                }

            }

        }
        static void WBudowie()
        {
            Console.WriteLine("W Budowie");
            Console.ReadKey();
        }
        static void Potega()
        {
            Console.WriteLine("Podaj podstawę potęgi");
            double Podstawa = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Wykładnik potęgi");
            var Wykladnik = int.Parse(Console.ReadLine());
            double Wynik = Podstawa;
            for (int i = 0; i < Wykladnik - 1; i++)
            {
                Wynik = Wynik * Podstawa;
            }

            Console.Write(Podstawa); Console.Write(" do potęgi "); Console.Write(Wykladnik); Console.Write(" to "); Console.WriteLine(Wynik);
            Console.ReadKey();
        }
        static void Silnia()
        {
            Console.WriteLine("Silnia: ");
            int Podstawa = int.Parse(Console.ReadLine());
        }

    }
}