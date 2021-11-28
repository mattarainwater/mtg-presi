using System;
using System.Collections.Generic;
using System.Text;

namespace MtgCardEngine.Tokens
{
    public class GainLife : Effect
    {
        public Number Amount { get; set; }

        public static new GainLife Parse(ref Queue<string> tokens)
        {
            var gainLife = new GainLife();
            gainLife.Amount = Number.Parse(ref tokens);
            return gainLife;
        }

        public override string ToString()
        {
            return $"gain {Amount} life";
        }
    }
}
