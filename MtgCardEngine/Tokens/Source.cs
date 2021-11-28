using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtgCardEngine.Tokens
{
    public class Source
    {
        public string Value { get; set; }

        public static Source Parse(ref Queue<string> tokens)
        {
            var source = new Source();
            source.Value = tokens.Dequeue();
            return source;
        }

        public override string ToString()
        {
            if(Value == "SELF")
            {
                return "When this effect";
            }
            else if (Value == "OTHERCREATURE")
            {
                return "When a creature";
            }
            else
            {
                return "ERROR";
            }
        }
    }
}
