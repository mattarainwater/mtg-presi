using System;
using System.Collections.Generic;
using System.Text;

namespace MtgCardEngine.Tokens
{
    public class Ability
    {
        public Trigger Trigger { get; set; }
        public Effect Effect { get; set; }

        public static Ability Parse(ref Queue<string> tokens)
        {
            var ability = new Ability();
            ability.Trigger = Trigger.Parse(ref tokens);
            ability.Effect = Effect.Parse(ref tokens);
            return ability;
        }

        public override string ToString()
        {
            return Trigger.ToString() + ", " + Effect.ToString() + ".";
        }
    }
}
