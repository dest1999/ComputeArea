using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeArea
{
    public class Circle : AbstractFigure
    {
        public double radius { get; private set; }

        public Circle() { } // конструктор по умолчанию для возможностей сериализации (если понадобится)

        /// <summary>
        /// Создает круг заданного радиуса
        /// </summary>

        public Circle(double Radius)
        {
            if (Radius < 0) // проверка на корректность ввода радиуса
            {
                throw new ArgumentException("Check input arguments");
            }
            radius = Radius;
        }

        public override double Area()
        {
            return radius * radius * Math.PI;
        }
    }
}
