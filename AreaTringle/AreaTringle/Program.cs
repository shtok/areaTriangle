using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using areaLib;

namespace AreaTringle
{
    class Program
    {
        static void Main(string[] args)
        {
             double a, b, c, st, z;
            
             Console.WriteLine("Построить прямоугольный треугольник и посчитать его площадь по 3м сторонам");
           
             const string INVITE = "Введите Вещественное Число: ";
             const string CONTINUE = "Продолжим? (y/n)";
             string answer = "y";

            do {
                Console.WriteLine(INVITE + "Катет (сторона) a = ");
                while (!double.TryParse(Console.ReadLine(), out a) || a<=0)
                {                  
                    Console.WriteLine("Введены неверные данные");
                    Console.WriteLine(INVITE + "Катет (сторона) a = ");
                }
                               

                Console.WriteLine(INVITE + "Катет (сторона) b = ");
                while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.WriteLine("Введены неверные данные");
                    Console.WriteLine(INVITE + "Катет (сторона) b = ");
                }

                z = Math.Round(triangle.Сhypotenuse(a, b),3);

                Console.WriteLine(INVITE + "Гипотенуза (сторона) c = ");
                while (!double.TryParse(Console.ReadLine(), out c) || c != z)
                {
                    Console.WriteLine("Введены неверные данные");
                    Console.WriteLine(" т.к. треугольник прямоугольный, гипотенуза должна быть равна " + z);
                    Console.WriteLine(INVITE + "Гипотенуза (сторона) c = ");
                }
                

                Console.WriteLine("По формуле Герона");

                st = Math.Round(triangle.Striangle(a, b, c),3);
                Console.WriteLine("Площадь прямоугольного треугольника равна " +st);

                Console.WriteLine(CONTINUE);
                answer = Console.ReadLine();

               }
            while (answer == "y");
             
        }
    }
}
