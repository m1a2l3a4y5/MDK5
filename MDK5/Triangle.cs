using System;
// Расскоментируй если эти библеотеки нужны или удали
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MDK5
{
    public class Triangle
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        // Добавил парочку конструкторов, на всякий
        public Triangle()
        {
            SetParams(0d,0d,0d);
        }

        // Добавил парочку конструкторов, на всякий
        public Triangle(double a, double b, double c)
        {
            SetParams(a,b,c);
        }

        public double CalcPerimeter()
        {
            return A + B + C;
        }

        public void SetParams(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void SetParams(double a, double b, double c, bool doubleSize)
        {
            if (doubleSize)
            {              
                A = 2 * a;
                B = 2 * b;
                C = 2 * c;               
            }else{
                // Если не будет работать, то просто перепиши метод сверху
                SetParams(a, b, c);
            }
            
        }
    }
}
