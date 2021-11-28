using MtgCardEngine.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtgCardEngine.Model
{
    public class Board
    {
        public Board()
        {
            Creatures = new List<Creature>();
            Abilities = new List<Ability>();
            LifeTotal = 20;
            Hand = new List<Card>();
        }

        public List<Creature> Creatures { get; set; }
        public List<Ability> Abilities { get; set; }
        public int LifeTotal { get; set; }
        public List<Card> Hand { get; set; }

        public void PlayCard(Card card)
        {
            Hand.Remove(card);
            if(card.Ability.Trigger.Source.Value == "SELF" && card.Ability.Trigger.Cause.Value == "ETB")
            {
                Apply(card.Ability);
            }
            else
            {
                Abilities.Add(card.Ability);
            }
        }

        private void Apply(Ability ability)
        {
            if (ability.Effect is GainLife)
            {
                var gainLife = ability.Effect as GainLife;
                LifeTotal += gainLife.Amount.Value;
            }
            if (ability.Effect is CreateToken)
            {
                var createToken = ability.Effect as CreateToken;
                for (var i = 0; i < createToken.Amount.Value; i++)
                {
                    Creatures.Add(new Creature
                    {
                        Color = createToken.Color,
                        Power = createToken.Power,
                        Toughness = createToken.Toughness,
                        Subtype = createToken.PermanentType.Subtype
                    });
                    var otherCreatureEtbAbilities = Abilities.Where(x => x.Trigger.Cause.Value == "ETB" && x.Trigger.Source.Value == "OTHERCREATURE");
                    foreach (var subAbility in otherCreatureEtbAbilities)
                    {
                        Apply(subAbility);
                    }
                }
            }
        }

        public override string ToString()
        {
            var desc = $"Life total: {LifeTotal}\r\n";

            desc += "Creatures on battlefield:\r\n";
            foreach(var creature in Creatures)
            {
                desc += $"{creature.Power}/{creature.Toughness} {creature.Color} {creature.Subtype}\r\n";
            }

            desc += "Abilities in play:\r\n";
            foreach (var ability in Abilities)
            {
                desc += $"{ability}\r\n";
            }

            desc += "Cards in hand:\r\n";
            for(var i = 0; i < Hand.Count; i++)
            {
                var card = Hand[i];
                desc += $"{i}: {card}\r\n";
            }

            return desc;
        }
    }
}
