using System;
using System.Collections.Generic;
using System.Linq;

namespace MtgCardEngine.Tokens
{
    public class CreateToken : Effect
    {
        public Number Amount { get; set; }
        public Power Power { get; set; }
        public Toughness Toughness { get; set; }
        public Color Color { get; set; }
        public PermanentType PermanentType { get; set; }

        public static new CreateToken Parse(ref Queue<string> tokens)
        {
            var createToken = new CreateToken();
            createToken.Amount = Number.Parse(ref tokens);
            createToken.Power = Power.Parse(ref tokens);
            createToken.Toughness = Toughness.Parse(ref tokens);
            createToken.Color = Color.Parse(ref tokens);
            createToken.PermanentType = PermanentType.Parse(ref tokens);
            return createToken;
        }

        public override string ToString()
        {
            return $"create {(Amount.Value == 1 ? "a" : Amount.ToString())} {Power}/{Toughness} {Color} {PermanentType} token{(Amount.Value == 1 ? "" : "s")}";
        }
    }
}
