using System; [ARRAY METHOD 1]
using System.Text;

namespace TestCode // ARRAY INPUT METHOD (1)
{
class Program
{
static void Main(string[] args)
{

            // Array Input [START]
            string[] answer = new string[5];
            Array.Sort(answer);
            for (int i = 0; i < answer.Length;i++)
            {
                Console.Write("Insert the name : ");
                answer[i] = Console.ReadLine();
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine(answer[i] + " was saved to the database (!)" + "\n");
                }
            }
            // Array Input [END]
            Console.Clear();
            Console.WriteLine("This is the first name : " + answer[0]);
            Console.WriteLine("This is the second name : " + answer[1]);
            Console.WriteLine("This is the third name : " + answer[2]);
            Console.WriteLine("This is the fourth name : " + answer[3]);
            Console.WriteLine("This is the fifth name : " + answer[4]);
            Console.ReadLine();
            Console.Clear();
        }
    }

}

[================================================================================================================================]

using System; [ARRAY METHOD 2]
using System.Text;

namespace TestCode // ARRAY INPUT METHOD (2)
{
class Program
{
static void Main(string[] args)
{
int i;
// Array Input [START]
string[] answer = new string[5];
Array.Sort(answer);
for (i = 0; i < answer.Length;i++)
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
for (i = 0;i < answer.Length;i++)
{

                Console.WriteLine("[===============]" + answer[i]);
            }
            // Array Printing [END]
            Console.ReadLine();
        }
    }

}
