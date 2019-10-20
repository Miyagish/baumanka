using System;

namespace Lab_1_BKID_Yakshin_IU5_35B
{
    class Program
    {
        //-----------------------------------------------------------------
        static double func(string consoleMessage)
        {
            string x;
            double y;
            bool z;
            do
            {
                Console.Write(consoleMessage);
                x = Console.ReadLine();
                if (!(z = double.TryParse(x, out y)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод!");
                    Console.ResetColor();
                }
            }
            while (!z);
            return y;
        }
        //-------------------------------------------------------------------
        static void Main(string[] args)
        {
            Console.Title = "Якшин Егор ИУ5-35Б";
            double a;
            double b;
            double c;
            if (args.Length == 3)
            {
                Console.WriteLine("Биквадратное уравнение вида ax^4+bx^2+c=0");
                Console.WriteLine("Аргументы из командной строки");
                try
                {
                    a = Double.Parse(args[0]);
                    b = Double.Parse(args[1]);
                    c = Double.Parse(args[2]);
                }
                catch
                {
                    Console.WriteLine("Аргументы командной строки некорректны! ");
                    a = func("Введите коэффициент А: ");
                    b = func("Введите коэффициент B: ");
                    c = func("Введите коэффициент C: ");
                }
            }
            else
            {
                a = func("Введите коэффициент А: ");
                b = func("Введите коэффициент B: ");
                c = func("Введите коэффициент C: ");
            }
            if (a == 0 && b != 0)
            {
                if (c < 0)
                {
                    double s1;
                    double s = -1 * c / b;
                    s1 = Math.Sqrt(s);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения: " + s1 + " и -" + s1);
                }
                else if (c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корень уравнения: 0");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет");
                }
            }
            if (a != 0 && b == 0)
                {
                    if (c < 0)
                    {
                        double s1, s2;
                        double s = -1 * c / a;
                        s1 = Math.Sqrt(s);
                        s2 = Math.Sqrt(s1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения: " + s2 + " и -" + s2);
                    }
                    else if (c == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корень уравнения: 0");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет");

                    }
                }
            if (a != 0 && b != 0)
                {
                    double d = Math.Pow(b, 2) - 4 * a * c;
                    {
                        if (d < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Корней нет");
                        }
                        else if (d == 0)
                        {
                            double s = Math.Sqrt((b + Math.Sqrt(d)) / (2 * a));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Корни уравнения: " + s + " и -" + s);
                        }
                        else
                        {
                        double s1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                        double s2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корень 1:  " + Math.Sqrt(s1));
                        Console.WriteLine("Корень 2: -" + Math.Sqrt(s1));
                        Console.WriteLine("Корень 3:  " + Math.Sqrt(s2));
                        Console.WriteLine("Корень 4: -" + Math.Sqrt(s2));
                    }
                        Console.ReadLine();
                    }
                }
            }
        }
    }

