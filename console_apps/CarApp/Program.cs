using System;
using System.IO;
using System.Collections.Generic;

namespace Json
{ 
    public class Program : PersonData
    {
        static PersonData person = new PersonData();
        public static void Main()
        {
            char[] carClasses = { 'A', 'B', 'C' };

            Console.Write("Insert the name : ");
            person.personName = Console.ReadLine();

            Console.Write("Insert the age : ");
            person.personAge = Int32.Parse(Console.ReadLine());

            Console.Write("Insert the height : ");
            person.personHeight = Double.Parse(Console.ReadLine());

            Console.Write("What vechile do you have ? (truck, motorbike, car) : ");
            string car = Console.ReadLine();

            Console.Write("In what continent do you live : ");
            person.personContinent = Console.ReadLine();
            
            
            if (checkAllowToDrive(person.personAge) == true)
            {
                person.have = true;
                carClassSelection(car, carClasses);

                string alphabet = "abcdefghijklmnopqrstuvwxyz0123456789";

                var random = new Random();
                if (person.personContinent.StartsWith("U"))
                {
                    string carPlate = "USA_";
                    for (int i = 0; i < 5; i++)
                    {
                        var randomIndex = random.Next(0, alphabet.Length);
                        string yourRandomCharacter = alphabet[randomIndex].ToString();

                        carPlate += yourRandomCharacter;
                    }

                    Console.WriteLine($"Your car plate : {carPlate }");
                    Console.WriteLine($"Your car class : {person.CarClass}");
                    Console.WriteLine("Your license is VALID");
                }
                else if (person.personContinent.StartsWith("E"))
                {
                    string carPlate = "EU_";
                    for (int i = 0; i < 5; i++)
                    {
                        var randomIndex = random.Next(0, alphabet.Length);
                        string yourRandomCharacter = alphabet[randomIndex].ToString();

                        carPlate += yourRandomCharacter;
                    }

                    Console.WriteLine($"Your car plate : {carPlate }");
                    Console.WriteLine($"Your car class : {person.CarClass}");
                    Console.WriteLine("Your license is VALID");
                }
            }
            else
            {

            }
        }

        static bool checkAllowToDrive(int age)
        {
            bool hasLicense = false;
            if (person.personContinent.StartsWith("U"))
                if (age > 16)
                    hasLicense = true;
                else
                    hasLicense = false;
            else if (person.personContinent.StartsWith("E"))
                if (age > 18)
                    hasLicense = true;
                else
                    hasLicense = false;

            return hasLicense;
        }

        static char carClassSelection(string car, char[] carClasses)
        {
            if (car == "car")
                person.CarClass = carClasses[0];
            else if (car == "motorbike")
                person.CarClass = carClasses[1];
            else if (car == "truck")
                person.CarClass = carClasses[3];


            return person.CarClass;
        } 
    }
}
