using MtgCardEngine.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace MtgCardEngine.Model
{
    public class Card
    {
        public Ability Ability { get; set; }

        public override string ToString()
        {
            return Ability.ToString();
        }
    }
}
