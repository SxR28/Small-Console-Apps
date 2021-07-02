using System; // MAIN SYSTEM 

namespace RequestingApp // This is the app code, the code is the basic code that camed with the app
{
    class Program
    {
        static void Main(string[] args)
        { // CODE BRACKETS

            Console.WriteLine("Hello, Im the HR Manager, I will be ask you some questions !");
            Console.WriteLine("After completing the fields, please click to continue, this proces is because our DB has problems");
            Console.Write("So,what is your first name ?");
            string MyFirstNameFromInterview;
            MyFirstNameFromInterview = Console.ReadLine();
            Console.ReadLine();

            Console.Write("What is your middle name ?");
            string MyMiddleNameFromInterview;
            MyMiddleNameFromInterview = Console.ReadLine();
            Console.ReadLine();

            Console.Write("What is your last name ?");
            string MyLastNameFromInterview;
            MyLastNameFromInterview = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Result = " + MyFirstNameFromInterview + " " + MyMiddleNameFromInterview + " " + MyLastNameFromInterview);
        }
    }
}