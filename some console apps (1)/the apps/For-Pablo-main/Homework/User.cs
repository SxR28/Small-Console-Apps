using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class User : Validation
    {
        public int ChooseShape(int shape)
        {
            Console.WriteLine("Choose the shape (Type the number in the input) : " +
                                    "\n 1. Square " +
                                    "\n 2. Rectangle " +
                                    "\n 3. Circle" +
                                    "\n 4. Exit");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Insert the number : ");
            shape = Int32.Parse(Console.ReadLine());

            Shape = shape;
            return Shape;
        }
    }
}
