using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtgCardEngine.Tokens
{
    public class Color
    {
        private static readonly string[] COLOR_ARRAY = new string[]
        {
            "WHITE",
            "BLUE",
            "BLACK",
            "RED",
            "GREEN",
            "COLORLESS",
        };

        public string[] Colors { get; set; }

        public static Color Parse(ref Queue<string> tokens)
        {
            var colors = new string[] { tokens.Dequeue() };
            while(COLOR_ARRAY.Contains(tokens.Peek())) {
                colors.Append(tokens.Dequeue());
            }
            return new Color
            {
                Colors = colors
            };
        }

        public override string ToString()
        {
            return string.Join(' ', Colors.Select(x => x.ToLower()));
        }
    }
}
