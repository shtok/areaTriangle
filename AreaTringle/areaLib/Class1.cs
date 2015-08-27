using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaLib
{
   
        public static class triangle
        {
            public const string ChypotenuseMessageZero = "Длина стороны треугольника должна быть больше нуля";
            public static double Сhypotenuse(double x, double y)
            {
               if (x <= 0) throw new ArgumentOutOfRangeException("a", ChypotenuseMessageZero);
               if (y <= 0) throw new ArgumentOutOfRangeException("b", ChypotenuseMessageZero);

                double c = Math.Sqrt((x * x) + (y * y));
                return c;

            }
            public static double Striangle(double x, double y, double z)
            {
                if (x <= 0) throw new ArgumentOutOfRangeException("a", ChypotenuseMessageZero);
                if (y <= 0) throw new ArgumentOutOfRangeException("b", ChypotenuseMessageZero);
                if (x <= 0) throw new ArgumentOutOfRangeException("a", ChypotenuseMessageZero);
                

                double p = (x + y + z) / 2;
                
                double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
                return s;
            }

        }
    
}
