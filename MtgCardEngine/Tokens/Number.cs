using System;
using System.Collections.Generic;
using System.Text;

namespace MtgCardEngine.Tokens
{
    public class Number
    {
        public int Value { get; set; }

        public static Number Parse(ref Queue<string> tokens)
        {
            var number = new Number();
            number.Value = int.Parse(tokens.Dequeue());
            return number;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
