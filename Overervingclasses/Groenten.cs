using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overervingclasses
{
    public class Groenten:Vegetarisch
    {
        public string Mineraal { get; set; }

       public Groenten(string naam, string kleur, List<string> voedingsstoffen, string vitamine,String mineraal):base(naam,kleur,voedingsstoffen,vitamine)
        {
            Mineraal = mineraal;
        }
        public Groenten(string naam, string kleur, string vitamine, String mineraal) : base(naam, kleur, vitamine)
        {
            Mineraal = mineraal;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $"Het heeft {Mineraal} is.";
        }


       

    }
}
