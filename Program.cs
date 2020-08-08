using Microsoft.VisualBasic;
using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;

namespace kurs2
{
    class Program
    {
        public enum Mark
        {
            Niedostateczny, Dopuszczający, Dostateczny, Dobry, BardzoDobry, Celujący
        }
        public enum Day
        {
            Poniedziałek, Wtorek, Środa, Czwartek, Piątek, Sobota, Niedziela
        }
        static class Math
        {
            public static double Addition(double a, double b) => a + b;
            public static double Substraction(double a, double b) => a - b;
            public static double Multiply(double a, double b) => a * b;
            public static double Division(double a, double b)
            {
                if (b == 0)
                {
                    throw new ArgumentException(message: "Can't divide by 0!", paramName: nameof(b));
                }
                return a / b;
            }
            public static double Pow(double a) => a * a;
            public static double Power(double a) => a * a * a;
            public static double Sqrt(double a) => Math.Sqrt(a);
            public static double mod(double a, double b) => a % b;
        }
        static void Main(string[] args)
        {
            Console.Write("Zad. 1 \r\n");
            int a1 = 5;
            int b1 = 5;
            if (a1 == b1)
            {
                Console.WriteLine("Zmienne są równe");
            }
            else
                Console.WriteLine("Zmienne są różne");

            Console.Write("Zad. 2 \r\n");
            int c = 15;
            if (c % 2 == 0)
            {
                Console.WriteLine("Liczba parzysta");
            }
            else
                Console.WriteLine("Liczba nieparzysta");

            Console.Write("Zad. 3 \r\n");
            int d = 14;
            if (d < 0)
            {
                Console.WriteLine("Liczba ujemna");
            }
            else
                Console.WriteLine("Liczba dodatnia");

            Console.Write("Zad. 4 \r\n");
            int year = 2016;
            if (year % 4 == 0)
            {
                Console.WriteLine("Rok jest przestępny");
            }
            else
                Console.WriteLine("Rok nie jest przestępny");

            Console.Write("Zad. 5 \r\n");
            Console.WriteLine("Podaj swój wiek: ");
            int e = Int32.Parse(Console.ReadLine());
            if (e >= 35)
            {
                Console.WriteLine("Możesz zostać posłem, senatorem lub prezydentem");
            }
            else if (e >= 30)
            {
                Console.WriteLine("Możesz zostać posłem lub senatorem");
            }
            else if (e >= 21)
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            else
                Console.WriteLine("Nie możesz ubiegać się o stanowisko w rządzie");

            Console.Write("Zad. 6 \r\n");
            Console.WriteLine("Podaj swój wzrost: ");
            int f = Int32.Parse(Console.ReadLine());
            if (f >= 140 && f <= 150)
            {
                Console.WriteLine("Jesteś karzełkiem");
            }
            else if (f > 150 && f <= 170)
            {
                Console.WriteLine("Jesteś średniego wzrostu");
            }
            else if (f > 170 && f <= 190)
            {
                Console.WriteLine("Jesteś wyższy niż średni");
            }
            else if (f > 190 && f <= 210)
            {
                Console.WriteLine("Jesteś wielkoludem");
            }
            else
                Console.WriteLine("Jesteś za mały lub nie jesteś już człowiekiem ;-)");

            Console.Write("Zad. 7 \r\n");
            int g = 25;
            int h = 63;
            int i = 79;

            if (g > h && g > i)
            {
                Console.WriteLine("Liczba " + g + " jest największa");
            }
            else if (h > g && h > i)
            {
                Console.WriteLine("Liczba " + h + " jest największa");
            }
            else
                Console.WriteLine($"Liczba " + i + " jest największa");

            Console.Write("Zad. 8 \r\n");
            int mat = 80;
            int fiz = 71;
            int chem = 0;
            if ((mat > 70 && fiz > 55 && chem > 45 && mat + fiz + chem > 180) || ((mat + fiz > 150) || (mat + chem > 150)))
            {
                Console.WriteLine("Student przyjęty do rekrutacji");
            }
            else
                Console.WriteLine("Student odrzucony z rekrutacji");

            Console.WriteLine("Zad. 9 \r\n");
            Console.Write("Podaj temperaturę za oknem: ");
            int temp = Int32.Parse(Console.ReadLine());
            switch (temp)
            {
                case int t when t <= 0:
                    Console.WriteLine("Cholernie piździ!!!!");
                    break;
                case int t when t > 0 && t <= 10:
                    Console.WriteLine("Zimno!!");
                    break;
                case int t when t > 10 && t <= 20:
                    Console.WriteLine("Chłodno!!");
                    break;
                case int t when t > 20 && t <= 30:
                    Console.WriteLine("W sam raz!!");
                    break;
                case int t when t > 30 && t <= 40:
                    Console.WriteLine("Zaczyna być słabo, bo gorąco!");
                    break;
                case int t when t > 40:
                    Console.WriteLine("A weź, wyprowadzam się na Alaskę!");
                    break;
                default:
                    Console.WriteLine("Nie podano temperatury");
                    break;
            }

            Console.WriteLine("Zad. 10 \r\n");
            Console.Write("Podaj długość pierwszego boku: ");
            int j = Int32.Parse(Console.ReadLine());
            Console.Write("Podaj długość drugiego boku: ");
            int k = Int32.Parse(Console.ReadLine());
            Console.Write("Podaj długość trzeciego boku: ");
            int l = Int32.Parse(Console.ReadLine());
            int result = j * j + k * k;
            if (result == l * l)
            {
                Console.WriteLine("Da się zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Zonk!");
            }

            Console.WriteLine("Zad. 11 \r\n");
            Console.Write("Write a note (1-6): ");

            int note = Int32.Parse(Console.ReadLine());
            var mark = note switch
            {
                1 => Mark.Niedostateczny,
                2 => Mark.Dopuszczający,
                3 => Mark.Dostateczny,
                4 => Mark.Dobry,
                5 => Mark.BardzoDobry,
                6 => Mark.Celujący,
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(Mark)),
            };
            Console.WriteLine($"Your mark is {mark}");

            Console.WriteLine("Zad. 12 \r\n");
            Console.WriteLine("Write down number of the current day (1-7): ");
            int numb = Int32.Parse(Console.ReadLine());
            var day = numb switch
            {
                1 => Day.Poniedziałek,
                2 => Day.Wtorek,
                3 => Day.Środa,
                4 => Day.Czwartek,
                5 => Day.Piątek,
                6 => Day.Sobota,
                7 => Day.Niedziela,
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(Day)),
            };
            Console.WriteLine($"The Current Day is {day}");
            Console.WriteLine("Zad. 13 \r\n");
            Console.Write("Type the first value: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Type the second value: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Choose one of the mathematical operations below:\n 1. Addition \n 2. Substraction \n 3. Multiplication \n 4. Division \n 5.x^2 \n 6.x^3 \n 7.Sqrt \n 8. mod");
            int val = Int32.Parse(Console.ReadLine());
            var math = val switch
            {
                1 => Math.Addition(a, b),
                2 => Math.Substraction(a, b),
                3 => Math.Multiply(a, b),
                4 => Math.Division(a, b),
                5 => Math.Pow(a),
                6 => Math.Power(a),
                7 => Math.Sqrt(a),
                8 => Math.mod(a, b),
                _ => throw new ArgumentException(message: "No operation chosen or number of operation out of range.", paramName: nameof(Math)),
            };
            Console.WriteLine($"Result is: {math}");
            Console.ReadKey();
        }
    }
}