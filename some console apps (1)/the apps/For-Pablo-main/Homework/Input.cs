using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Input : User
    {
        public (double,double) GetInput(int _value1, int _value2)
        {
            switch (Shape)
            {
                case 1:
                    Console.Write("Insert the value of the square side : ");
                    valueToBeParsed = Console.ReadLine();
                    ValuesValidation();

                    break;

                case 2:
                    Console.Write("Insert the rectangle width : ");
                    valueToBeParsed = Console.ReadLine();

                    Console.Write("Insert the second height : ");
                    valueToBeParsed2 = Console.ReadLine();

                    ValuesValidation();
                    break;

                case 3:
                    Console.Write("Insert the circle raze : ");
                    valueToBeParsed = Console.ReadLine();
                    ValuesValidation();


                    break;
            }

            return (_value1,_value2);
        }
    }
}
