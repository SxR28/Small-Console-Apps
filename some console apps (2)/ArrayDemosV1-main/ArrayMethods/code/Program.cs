using System;
using System.Text;

namespace ConsoleTest
{
    public enum ArraysTypes
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            bool StartExe = true;

            Console.WriteLine("Array Function Demos for Beginners <3");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The program gets an array , with length too ! , [CLICK TO CLEAR AND BEGIN]" + "\n");
            Console.WriteLine("You have 3 array options : double ; integer and string ");
            Console.ReadLine();
            Console.Clear();

            while (StartExe == true)
            {
                Console.Write("What array do you want  ? : ");
                string AnswerArrayOption = Console.ReadLine();

                switch (AnswerArrayOption)
                {
                    case "string":
                        ArrayString();
                        break;
                    // ------------------------------------------------------------------------------------------------------------------------
                    case "integer":
                        ArrayInteger();
                        break;
                    // ------------------------------------------------------------------------------------------------------------------------
                    case "double":
                        ArrayDouble();
                        break;
                }
                break;
            }
            static void ArrayString()
            {
                Console.Write("Inserth the length :");
                int ArrayStringLength = Convert.ToInt32(Console.ReadLine());


                int i, j;

                string[] AnswerString = new string[ArrayStringLength];
                Array.Sort(AnswerString);
                for (i = 0; i < AnswerString.Length; i++)
                {
                    Console.Write("Insert the name : ");
                    AnswerString[i] = Console.ReadLine();
                    for (j = 0; j < 1; j++)
                    {
                        Console.WriteLine(AnswerString[i] + " was saved to the database (!)" + "\n");
                    }
                }

                Console.WriteLine("[===============]");
                for (i = 0; i < AnswerString.Length; i++)
                {
                    Console.WriteLine(AnswerString[i]);
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Now, that you choose your array and did the steps, would you like to see the methods of it into an example ?");
                Console.ReadLine();
                Console.Clear();

                Console.Write("Insert your option : ");
                string OptionString = Console.ReadLine();
                if (OptionString == "yes")
                {
                    Console.Clear();

                    Console.WriteLine("Method 1 : -- [Array Length of elements] == " + AnswerString.Length + " elements");
                    Console.WriteLine("Method 2 : -- [Array Rank] == " + AnswerString.Rank);
                    Console.WriteLine("Method 3 : -- [Says the type of the elements] == " + AnswerString.GetType());
                    Console.WriteLine("Method 4 : -- [Says if the array has a fixed size] == " + AnswerString.IsFixedSize);
                    Console.WriteLine("Method 4.1 : -- [] == " + AnswerString.IsFixedSize);

                }
            }
            static void ArrayInteger()
            {
                Console.Write("Inserth the length :");
                int ArrayIntegerLength = Convert.ToInt32(Console.ReadLine());


                int k, l;

                int[] AnswerInteger = new int[ArrayIntegerLength];
                Array.Sort(AnswerInteger);
                for (k = 0; k < AnswerInteger.Length; k++)
                {
                    Console.Write("Insert the name : ");
                    AnswerInteger[k] = Convert.ToInt32(Console.ReadLine());
                    for (l = 0; l < 1; l++)
                    {
                        Console.WriteLine(AnswerInteger[k] + " was saved to the database (!)" + "\n");
                    }
                }

                Console.WriteLine("[===============]");
                for (k = 0; k < AnswerInteger.Length; k++)
                {
                    Console.WriteLine(AnswerInteger[k]);
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Now, that you choose your array and did the steps, would you like to see the methods of it into an example ?");
                Console.ReadLine();
                Console.Clear();

                Console.Write("Insert your option : ");
                string OptionInteger = Console.ReadLine();
                if (OptionInteger == "yes")
                {
                    Console.Clear();

                    Console.WriteLine("Method 1 : -- [Array Length of elements] == " + AnswerInteger.Length + " elements");
                    Console.WriteLine("Method 2 : -- [Array Rank] == " + AnswerInteger.Rank);
                    Console.WriteLine("Method 3 : -- [Says the type of the elements] == " + AnswerInteger.GetType());
                    Console.WriteLine("Method 4 : -- [Says if the array has a fixed size] == " + AnswerInteger.IsFixedSize);
                    Console.WriteLine("Method 4.1 : -- [] == " + AnswerInteger.IsFixedSize);

                }
            }
            static void ArrayDouble()
            {
                Console.Write("Inserth the length :");
                int ArrayDoubleLength = Convert.ToInt32(Console.ReadLine());


                int g, p;

                double[] AnswerDouble = new double[ArrayDoubleLength];
                Array.Sort(AnswerDouble);
                for (g = 0; g < AnswerDouble.Length; g++)
                {
                    Console.Write("Insert the name : ");
                    AnswerDouble[g] = Convert.ToDouble(Console.ReadLine());
                    for (p = 0; p < 1; p++)
                    {
                        Console.WriteLine(AnswerDouble[p] + " was saved to the database (!)" + "\n");
                    }
                }

                Console.WriteLine("[===============]");
                for (g = 0; g < AnswerDouble.Length; g++)
                {
                    Console.WriteLine(AnswerDouble[g]);
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Now, that you choose your array and did the steps, would you like to see the methods of it into an example ?");
                Console.ReadLine();
                Console.Clear();

                Console.Write("Insert your option : ");
                string OptionDouble = Console.ReadLine();
                if (OptionDouble == "yes")
                {
                    Console.Clear();

                    Console.WriteLine("Method 1 : -- [Array Length of elements] == " + AnswerDouble.Length + " elements");
                    Console.WriteLine("Method 2 : -- [Array Rank] == " + AnswerDouble.Rank);
                    Console.WriteLine("Method 3 : -- [Says the type of the elements] == " + AnswerDouble.GetType());
                    Console.WriteLine("Method 4 : -- [Says if the array has a fixed size] == " + AnswerDouble.IsFixedSize);
                    Console.WriteLine("Method 4.1 : -- [] == " + AnswerDouble.IsFixedSize);

                }
            }
        }
    }
}
