using System;
using System.Collections.Generic;
using System.Text;

namespace MtgCardEngine.Tokens
{
    public class Subtype
    {
        public string Value { get; set; }

        public static Subtype Parse(ref Queue<string> tokens)
        {
            return new Subtype
            {
                Value = tokens.Dequeue()
            };
        }

        public override string ToString()
        {
            return Value.ToString().ToLower();
        }
    }
}
