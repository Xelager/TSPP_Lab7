using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TSPPWorkInBank
{
    class Program
    {
       
        Vector2<double> coord;

        public struct Vector2<T>
        {
            public T x;
            public T y;
        }



        static void Get_Coordinates(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            return;
        }

        public static int Main (params string[] items)
        {
            Get_Coordinates(20, 20);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            do
            {
                Console.WriteLine("1 Ввод\n2 Расчет\n3 Сохранение\n4 выход");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ввод");
                        
                        break;
                    case 2:
                        Console.WriteLine("Расчет");
                        break;
                    case 3:
                        Console.WriteLine("Сохранение");
                        break;
                    case 4:
                        Console.WriteLine("выход");
                        return 1000;

                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            } while (true);
        }
    }
}
