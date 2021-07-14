using System;

namespace ArrayInput2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            // Array Input [START]
            string[] answer = new string[5];
            Array.Sort(answer);
            for (i = 0; i < answer.Length; i++)
            {
                Console.Write("Insert the name : ");
                answer[i] = Console.ReadLine();
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine(answer[i] + " was saved to the database (!)" + "\n");
                }
            }
            // Array Input [END]
            // Array Printing [START]
            for (i = 0; i < answer.Length; i++)
            {

                Console.WriteLine("[===============]" + answer[i]);
            }
            // Array Printing [END]
            Console.ReadLine();
        }
    }
}
