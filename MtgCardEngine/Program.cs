using System;

namespace MtgCardEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileText = System.IO.File.ReadAllText(@"Data\cards.txt");
            var parser = new Parser();
            var cards = parser.Parse(fileText);
            foreach(var card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
