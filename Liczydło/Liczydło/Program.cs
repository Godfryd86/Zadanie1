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
            Console.Title = "Liczydło";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Witaj. Co chcesz policzyć? (wciśnij cyfrę odpowiadającą działaniu)");
                Console.WriteLine("1. Potęga");
                Console.WriteLine("2. Silnia");
                Console.WriteLine("3. Pole i Obwód Koła");
                Console.WriteLine("4. Zapisać liczbę w systemie binarnym (dwójkowym)");
                Console.WriteLine("5. Wyjdź");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); Power(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); Factorial(); break;
                    case ConsoleKey.D3:
                        Console.Clear(); Circle(); break;
                    case ConsoleKey.D4:
                        Console.Clear(); Binary(); break;
                    case ConsoleKey.D5:
                        Environment.Exit(0); break;
                    default: break;
                }

            }

        }
        static void Power()
        {
            Console.WriteLine("Podaj podstawę potęgi");
            double V1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Wykładnik potęgi");
            var V2 = int.Parse(Console.ReadLine());
            double Res = V1;
            for (int i = 0; i < V2 - 1; i++)
            {
                Res = Res * V1;
            }

            Console.Write(V1); Console.Write(" do potęgi "); Console.Write(V2); Console.Write(" to "); Console.WriteLine(Res);
            Console.ReadKey();
        }
        static void Factorial()
        {
            Console.WriteLine("Silnia: ");
            var V1 = ulong.Parse(Console.ReadLine());
            ulong Res = V1;
            for (ulong i = V1-1; i >= 2; --i)
            {
                Res = i * Res;
            }

            Console.Write(" silnia z "); Console.Write(V1); Console.Write(" to "); Console.WriteLine(Res);
            Console.ReadKey();
        }
        static void Circle()
        {
            Console.WriteLine("Podaj promień");
            double r = double.Parse(Console.ReadLine());
            double Pi = 3.14;
            var Circum = Pi * r * 2;
            var Field = Pi * r * r;

            Console.WriteLine("Obwód to"); Console.WriteLine(Circum); Console.WriteLine("Pole to"); Console.WriteLine(Field);
            Console.ReadKey();
        }
        static void Binary()
        {
            Console.WriteLine("Podaj liczbę, którą mam zamienić na jej odpowiednik w kodzie binarnym");
            var V1 = int.Parse(Console.ReadLine());
            var result = string.Empty;

            while (V1 !=  0)
            {
                var temp = V1 % 2;
                result += temp.ToString(); 
                V1 /= 2; 
            }

            var trueResult = string.Empty;

            for
                 (int i = result.Length - 1; i >= 0; i--)
                trueResult += result[i];

            Console.WriteLine("w kodzie binarnym to " + trueResult);
            Console.WriteLine(string.Format("w kodzie to {0}", trueResult));
            Console.ReadKey();
        }
    }
}