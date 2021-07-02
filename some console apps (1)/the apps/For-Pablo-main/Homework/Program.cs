using System;

namespace Homework
{
    class Program
    { 
        static void Main(string[] args)
        {
            Output outputClass = new Output();

            outputClass.ChooseShape(0);
            outputClass.GetInput(0,0);
            outputClass.Printing();
        }
    }
}
