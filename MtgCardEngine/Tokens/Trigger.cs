using System;
using System.Collections.Generic;
using System.Linq;

namespace MtgCardEngine.Tokens
{
    public class Trigger
    {
        public Source Source { get; set; }
        public Cause Cause { get; set; }

        public static Trigger Parse(ref Queue<string> tokens)
        {
            var source = Source.Parse(ref tokens);
            var cause = Cause.Parse(ref tokens);
            return new Trigger
            {
                Source = source,
                Cause = cause,
            };
        }

        public override string ToString()
        {
            return Source.ToString() + " " + Cause.ToString();
        }
    }
}
