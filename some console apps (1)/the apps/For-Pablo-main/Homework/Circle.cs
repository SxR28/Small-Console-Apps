using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Circle : Values
    {
        private float Pi = 3.14f;

        public int Area(int result)
        {
            int circleAt2 = circleRaze * circleRaze;
            result = (int)(Pi * (float)circleAt2);

            circleAreaResult = result;
            return circleAreaResult;
        }

        public int Circumference(int result)
        {
            int diameter = circleRaze * 2;
            result = (int) (Pi * (float)diameter);

            circleCircumferenceResult = result;
            return circleCircumferenceResult;
        }
    }
}
