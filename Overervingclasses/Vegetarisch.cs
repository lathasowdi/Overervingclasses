using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overervingclasses
{
     public class Vegetarisch:Eten
    {
        public string Vitamine { get; set; }

       public Vegetarisch(string naam, string kleur, List<string> voedingsstoffen,string vitamine):base(naam,kleur,voedingsstoffen)
        {
            Vitamine = vitamine;
        }
        public Vegetarisch(string naam, string kleur,  string vitamine) : base(naam, kleur)
        {
            Vitamine = vitamine;
        }
        public override string Beschrijf()
        {
            return base.Beschrijf() + $"Die heeft Vitamine{Vitamine}. ";
        }
    }
}
