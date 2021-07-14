using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace GeneralTests
{
    class Program
    {
        static void Main(string[] args)
        {
            bool StartExe = true;
            List<int> NumbersInput = new List<int>();

            while (StartExe == true)
            {
                Console.Write("iNsErT a  NuMbEr In EaCh InPuT (eNtEr [0] To EnD)  : ");
                int Input = Convert.ToInt32(Console.ReadLine());
                NumbersInput.Add(Input);

                 if (Input == 0)
                    break;
            }
            Console.Clear();
            Console.Write("What numbers would you like to see, [Max] or [Min] ? : ");
            string Option = Console.ReadLine();

            switch (Option)
            {
                case "Max":
                    var MaxNumbers = NumbersInput.Max();
                    Console.Clear();
                    Console.WriteLine("Max : " + MaxNumbers);
                    break;

                case "Min":
                    var MinNumbers = NumbersInput.Min();
                    Console.Clear();
                    Console.WriteLine("Min : " + MinNumbers);
                    break;
            }
        }
    }
}
