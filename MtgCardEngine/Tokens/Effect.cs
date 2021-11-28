using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MtgCardEngine.Tokens
{
    public abstract class Effect
    {
        private static readonly Dictionary<string, Type> EFFECT_DICTIONARY = new Dictionary<string, Type>
        {
            { "CREATETOKEN", typeof(CreateToken) },
            { "GAINLIFE", typeof(GainLife) },
        };

        public static readonly int ParamCount = -1;

        public static Effect Parse (ref Queue<string> tokens)
        {
            var effectType = EFFECT_DICTIONARY[tokens.Dequeue()];

            var parseMethod = effectType.GetMethod("Parse", BindingFlags.Public | BindingFlags.Static);
            object[] arguments = new object[] { tokens };
            var effect = (Effect)parseMethod.Invoke(null, arguments);

            return effect;
        }
    }
}
