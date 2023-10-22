using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK5
{
    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        public double CalcPerimeter()
        {
            return sideA + sideB + sideC;
        }

        public void SetParams(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public void SetParams(double a, double b, double c, bool doubleSize)
        {
            if (doubleSize)
            {              
                sideA = 2 * a;
                sideB = 2 * b;
                sideC = 2 * c;               
            }
            
        }
    }
}
