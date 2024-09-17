namespace _5M03NWD
{
    internal class Program
    {
        private static int a, b, nwd;
        static void Main(string[] args)
        {
            Console.WriteLine("Program oblicza WND podanych liczb");
            do
            {
                string s;
                Console.WriteLine("podaj dwie dodatnie liczby całkowite");
                Console.WriteLine("podaj pierwszą liczbę:");
                s = Console.ReadLine();
                if(!int.TryParse(s, out a))
                {
                    Console.WriteLine("Nie podano liczby całkowitej");
                    continue;
                }
                Console.WriteLine("podaj drugą liczbę:");
                s = Console.ReadLine();
                if (!int.TryParse(s, out b))
                {
                    Console.WriteLine("Nie podano liczby całkowitej");
                    continue;
                }
                if(a <= 0 || b <= 0)
                {
                    Console.WriteLine("liczby powinny być dodatnie");
                    continue;
                }
                Console.WriteLine($"a i b: {a} i {b} ");
            } while (a <= 0 || b <= 0);

            nwd = NWD(a, b);

            Console.WriteLine($"Najwiekszym wspólnym dzielnikiem liczb {a} i {b} jest {nwd}");
        }
        /*************************************************************
         *  nazwa funkcji:       NWD(int a, int b)
         *  opis funkcji:        funkcja oblicza największy wspólny 
         *                       dzielnik liczb dodatnich (NWD)
         *                       podanych jako parametry
         *  Parametry:           a - liczba całkowita dodatnia
         *                       b - liczba całkowita dodatnia
         *  zwracany typ i opis: funkcja zwraca liczbę całkowitą będącą NWD parametrów
         *  Autor:               12345678912
         *  *********************************************************/
        private static int NWD(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
    }
}
