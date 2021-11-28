using System;
using System.Collections.Generic;
using System.Text;

namespace MtgCardEngine.Tokens
{
    public class Power
    {
        public Number Value { get; set; }

        public static Power Parse(ref Queue<string> tokens)
        {
            var power = new Power();
            power.Value = Number.Parse(ref tokens);
            return power;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
