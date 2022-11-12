using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeArea
{
    public class Circle : AbstractFigure
    {
        public override double Area(params double[] radius)
        {
            if (radius.Length != 1 || radius[0] < 0) // проверка на корректность ввода радиуса
            {
                throw new ArgumentException("Check input arguments");
            }

            return radius[0] * radius[0] * 3.14;
        }
    }
}
