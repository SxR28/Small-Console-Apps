using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Square : Values
    {
        public virtual int Perimeter(int result)
        {
            result = squareSide * 4;

            squarePerimeterResult = result;
            return squarePerimeterResult;
        }

        public virtual int Area(int result)
        {
            result = squareSide * squareSide;

            squareAreaResult = result;
            return squareAreaResult;
        }
    }
}
