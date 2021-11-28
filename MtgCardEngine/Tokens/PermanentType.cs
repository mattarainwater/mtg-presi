using System;
using System.Collections.Generic;
using System.Text;

namespace MtgCardEngine.Tokens
{
    public class PermanentType
    {
        public string Value { get; set; }
        public Subtype Subtype { get; set; }

        public static PermanentType Parse(ref Queue<string> tokens)
        {
            var value = tokens.Dequeue();
            Subtype subtype = null;
            if(value == "CREATURE")
            {
                subtype = Subtype.Parse(ref tokens);
            }
            return new PermanentType
            {
                Value = value,
                Subtype = subtype
            };
        }

        public override string ToString()
        {
            if(Subtype != null)
            {
                return Subtype.ToString().ToLower() + " " + Value.ToString().ToLower();
            }
            return Value.ToString().ToLower();
        }
    }
}
