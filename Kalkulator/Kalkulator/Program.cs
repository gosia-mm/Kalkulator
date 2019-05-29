using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        public static double Dodawanie(double liczba1, double liczba2)
        {
            return liczba1 + liczba2;
        }

        public static double Odejmowanie(double liczba1, double liczba2)
        {
            return liczba1 - liczba2;
        }

        public static double Mnozenie(double liczba1, double liczba2)
        {
            return liczba1 * liczba2;
        }

        public static double Dzielenie(double liczba1, double liczba2)
        {
            if (liczba2 != 0)
                return liczba1 / liczba2;
            else
            {
                Console.WriteLine("Nie dziel przez 0!");
                return 0;
            }
        }

        public static double WykonanieDzialania(double liczba1, double liczba2, string dzialanie)
        {
            double wynik = 0;

            switch (dzialanie)
            {
                case "Dodawanie":
                    wynik = Dodawanie(liczba1, liczba2);
                    break;
                case "Odejmowanie":
                    wynik = Odejmowanie(liczba1, liczba2);
                    break;
                case "Mnozenie":
                    wynik = Mnozenie(liczba1, liczba2);
                    break;
                case "Dzielenie":
                    wynik = Dzielenie(liczba1, liczba2);
                    break;
                default:
                    Console.WriteLine("Nie wybrano działania");
                    break;
            }

            return wynik;
        }

        static void Main(string[] args)
        {
            double liczba1 = 0, liczba2 = 0;
            string dzialanie = "";

            double wynik = WykonanieDzialania(liczba1, liczba2, dzialanie);

        }
    }
}
