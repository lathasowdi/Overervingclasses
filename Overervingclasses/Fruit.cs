using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overervingclasses
{
    public class Fruit:Vegetarisch
    {
        public double Water { get; set; }

        public Fruit(string naam, string kleur, List<string> voedingsstoffen, string vitamine, double water) : base(naam, kleur, voedingsstoffen, vitamine)
        {
            Water = water;
        }
        public Fruit(string naam, string kleur, string vitamine, double water) : base(naam, kleur, vitamine)
        {
            Water = water;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $"Het Water content is {Water} is.";
        }
    }
}
