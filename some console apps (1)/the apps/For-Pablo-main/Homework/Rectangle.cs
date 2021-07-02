using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Rectangle : Square
    {
        public override int Perimeter(int result)
        {
            result = 2 * (rectangleHeight + rectangleWidth);

            rectanglePerimeterResult = result;
            return rectanglePerimeterResult;
        }

        public override int Area(int result)
        {
            result = rectangleHeight * rectangleWidth;

            rectangleAreaResult = result;
            return result;
        }
    }
}
