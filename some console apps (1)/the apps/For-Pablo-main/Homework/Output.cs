using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Output : Input
    {
        public void Printing()
        {
            switch (Shape) 
            {
                case 1:
                    Square squareClass = new Square();
                    squareClass.squareSide = this.squareSide;

                    squareClass.Area(1);
                    squareClass.Perimeter(1);

                    Console.WriteLine("Square Perimeter : {0}", squareClass.squarePerimeterResult);
                    Console.WriteLine("square Area : {0}", squareClass.squareAreaResult);
                    break;

                case 2:
                    Rectangle rectangleClass = new Rectangle();
                    rectangleClass.rectangleHeight = this.rectangleHeight;
                    rectangleClass.rectangleWidth = this.rectangleWidth;

                    rectangleClass.Area(1);
                    rectangleClass.Perimeter(1);

                    Console.WriteLine("Rectangle Perimeter : {0}", rectangleClass.rectanglePerimeterResult);
                    Console.WriteLine("Rectangle Area : {0}", rectangleClass.rectangleAreaResult);

                    break;

                case 3:
                    Circle circleClass = new Circle();
                    circleClass.circleRaze = this.circleRaze;

                    circleClass.Area(1);
                    circleClass.Circumference(1);

                    Console.WriteLine("Circle Area : {0}", circleClass.circleAreaResult);
                    Console.WriteLine("Circle Circumference : {0}", circleClass.circleCircumferenceResult);

                    break;
            }
        }
    }
}
