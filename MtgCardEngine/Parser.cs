using MtgCardEngine.Model;
using MtgCardEngine.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MtgCardEngine
{
    public class Parser
    {
        public List<Card> Parse(string fileText)
        {
            var cards = new List<Card>();
            var lines = fileText.Split("\r\n");
            foreach(var line in lines)
            {
                if(string.IsNullOrEmpty(line))
                {
                    continue;
                }
                var tokens = new Queue<string>(line.Split(" "));
                var card = new Card()
                {
                    Ability = Ability.Parse(ref tokens)
                };
                cards.Add(card);
            }
            return cards;
        }
    }
}
