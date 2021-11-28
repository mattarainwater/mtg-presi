using MtgCardEngine.Tokens;

namespace MtgCardEngine.Model
{
    public class Creature
    {
        public Color Color { get; set; }
        public Power Power { get; set; }
        public Toughness Toughness { get; set; }
        public Subtype Subtype { get; set; }
    }
}