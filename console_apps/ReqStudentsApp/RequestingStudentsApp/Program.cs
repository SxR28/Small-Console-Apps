using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace ReqAp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; // Global Variable


            Console.WriteLine("Hello,this app was developed especialy for theachers and school staff to monitorize the kids and the pupets (!)");
            Console.ReadLine();
            Console.WriteLine("Would you like to enter the app ?  : ");
            string OptionEntering;
            OptionEntering = Console.ReadLine();
            if (OptionEntering == "Continue")
            {
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You will need to input some values for the : pupils in  class , names ; grade ID");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("How many students are in the class ?");
                string StudentsNumber;
                StudentsNumber = Console.ReadLine();

                Console.WriteLine("What class ID are they ? ");
                string ClassID;
                ClassID = Console.ReadLine();

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Now that we got some class data , we need to get the students name ");
                string[] Answer = new string[5];
                Array.Sort(Answer);
                for (i = 0; i < Answer.Length; i++)
                {
                    Console.Write("Insert the name : ");
                    Answer[i] = Console.ReadLine();
                    for (int j = 0; j < 1; j++)
                    {
                        Console.WriteLine(Answer[i] + " was saved to the database (!)" + "\n");
                    }
                }

                Console.WriteLine("The number of students in the class : " + StudentsNumber);
                Console.WriteLine("The class ID : " + ClassID);
                Console.WriteLine("The names from the class are : " + "\n");
                for (i = 0; i < Answer.Length;i++)
                {
                    Console.WriteLine(Answer[i]);
                }

                string[] ClassInfo = // Array Storing 
                {
                    StudentsNumber,
                    ClassID,

                };
            }
            else if (OptionEntering == "Exit")
            {
                Console.WriteLine("Thank you , have a nice day");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("ERROR // YOU INSERTED SOMETHING WRONG");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
