using System;
using System.Collections.Generic;
using System.Text;

namespace MtgCardEngine.Tokens
{
    public class Toughness
    {
        public Number Value { get; set; }

        public static Toughness Parse(ref Queue<string> tokens)
        {
            var toughness = new Toughness();
            toughness.Value = Number.Parse(ref tokens);
            return toughness;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
