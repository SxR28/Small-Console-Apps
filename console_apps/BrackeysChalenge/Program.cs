using System;

namespace C__Code____M
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sentece word Counter");
            Console.ReadLine();
            Console.Clear();

            Counter();

        }
        static void Counter()
        {
            Console.Write("Insert a sentence : ");
            string sentence = Console.ReadLine();

            int WordCounting = CountWords(sentence);

            Console.WriteLine("The sentence has : " + WordCounting + " words");
        }
        static int CountWords(string sentence)
        {
            int WordCounting = sentence.Split(' ').Length;
            return WordCounting;
        }
    }
}
