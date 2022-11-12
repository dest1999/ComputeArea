using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeArea
{
    internal class Triangle : AbstractFigure
    {
        public override double Area(params double[] edges)
        {
            if (edges.Length != 3   ) //TODO добавить проверку на отрицательность ввода
            {
                throw new ArgumentException("Check input arguments");
            }

            double halfPerimeter = (edges[0] + edges[1] + edges[2]) / 2;
            return Math.Sqrt(halfPerimeter *
                            (halfPerimeter - edges[0]) *
                            (halfPerimeter - edges[1]) *
                            (halfPerimeter - edges[2]) );

        }
    }
}
