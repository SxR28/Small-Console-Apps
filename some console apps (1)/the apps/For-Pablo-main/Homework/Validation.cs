using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Validation : Values
    {
        public int parsedTestSquareSide;
        public int parsedTestRectangleWidth;
        public int parsedTestRectangleHeight;
        public int parsedTestCircleRaze;

        public Validation()
        {
            parsedTestSquareSide = squareSide;

            parsedTestRectangleWidth = rectangleWidth;
            parsedTestRectangleHeight = rectangleWidth;

            parsedTestCircleRaze = circleRaze;
        }

        public void ValuesValidation()
        {
            bool squareSucces = int.TryParse(valueToBeParsed, out parsedTestSquareSide);

            bool rectangleHeightSucces = int.TryParse(valueToBeParsed, out parsedTestRectangleHeight);
            bool rectangleWidthSucces = int.TryParse(valueToBeParsed2, out parsedTestRectangleWidth);

            bool circleRazeSucces = int.TryParse(valueToBeParsed, out parsedTestCircleRaze);

            if (Shape == 1 && squareSucces == true)
            {
                Console.WriteLine("Succsefully parsed at shape {0}", Shape);
                squareSide = parsedTestSquareSide;
            }
            else if (Shape == 2 && rectangleHeightSucces == true && rectangleWidthSucces == true)
            {
                Console.WriteLine("Succsefully parsed at shape {0}", Shape);

                rectangleHeight = parsedTestRectangleHeight;
                rectangleWidth = parsedTestRectangleWidth;
            }
            else if (Shape == 3 && circleRazeSucces == true)
            {
                Console.WriteLine("Succsefully parsed at shape {0}", Shape);

                circleRaze = parsedTestCircleRaze;
            }
            else
                Console.WriteLine("Inserted something wrong !");
        }
    }
}

/*
if (Shape == 1 && succes == true)
    Console.WriteLine("Succsefully parsed at shape {0}", Shape);
else if (Shape == 3 && succes == true)
    Console.WriteLine("Succsefully parsed at shape {0}", Shape);
else
    Console.WriteLine("Inserted something wrong !");
*/