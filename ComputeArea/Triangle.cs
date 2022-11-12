using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeArea
{
    public class Triangle : AbstractFigure
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }

        private double area = -1; //кэшируем значение чтоб не вычислять каждый раз

        private bool? isSquare = null;

        public Triangle() { }

        public Triangle(double A, double B, double C)
        {
            if (A < 0 || B < 0 || C < 0)
            {
                throw new ArgumentException("Check input arguments");
            }
            a = A;
            b = B;
            c = C;
        }

        public override double Area()
        {
            if (area == -1)
            {
                double halfPerimeter = (a + b + c) / 2;
                area = Math.Sqrt(halfPerimeter *
                                (halfPerimeter - a) *
                                (halfPerimeter - b) *
                                (halfPerimeter - c));
            }
            
            return area;
        }

        public bool isTriangleSquare()
        {
            if (!isSquare.HasValue)
            {
                //создадим массив со значениями сторон и сортируем его => последний элемент - гипотенуза
                double[] arr = { a, b, c };
                Array.Sort(arr);

                if (arr[2] * arr[2] == ((arr[0] * arr[0]) + (arr[1] * arr[1])) ) // у прямоугольного треугольника сумма квадратов катетов должна быть равна квадрату гипотенузы
                {
                    isSquare = true;
                }
                else
                {
                    isSquare= false;
                }
            }

            return isSquare.Value;
        }

    }
}
