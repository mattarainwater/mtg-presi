using MtgCardEngine.Model;
using System;
using System.Linq;

namespace MtgCardEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileText = System.IO.File.ReadAllText(@"Data\cards.txt");
            var parser = new Parser();
            var cards = parser.Parse(fileText);
            var boardState = new Board();
            boardState.Hand.AddRange(cards); 
            
            Console.WriteLine("Starting game...");
            Console.WriteLine(boardState);
            string line;
            while ((line = Console.ReadLine()) != "q")
            {
                try
                {
                    var num = int.Parse(line);
                    var card = boardState.Hand.ElementAt(num);
                    boardState.PlayCard(card);
                }
                catch (Exception)
                {
                    Console.WriteLine("Card not found.");
                }
                Console.WriteLine(boardState);
            }
            Console.WriteLine("Game done!");
        }
    }
}
