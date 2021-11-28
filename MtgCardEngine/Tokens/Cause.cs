using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtgCardEngine.Tokens
{
    public class Cause
    {
        public string Value { get; set; }

        public static Cause Parse(ref Queue<string> tokens)
        {
            var cause = new Cause();
            cause.Value = tokens.Dequeue();
            return cause;
        }

        public override string ToString()
        {
            if (Value == "ETB")
            {
                return "enters the battlefield";
            }
            else if (Value == "DIES")
            {
                return "dies";
            }
            else if (Value == "ATTACKS")
            {
                return "attacks";
            }
            else
            {
                return "ERROR";
            }
        }
    }
}
