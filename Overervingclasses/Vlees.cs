using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overervingclasses
{
   public class Vlees:Eten
   {
        public string Eiwit { get; set; }
        public Vlees(string naam, string kleur, List<string> voedingsstoffen, string eiwit) : base(naam, kleur, voedingsstoffen)
        {
            Eiwit = eiwit;
        }
        public Vlees(string naam, string kleur,string eiwit) : base(naam, kleur)
        {
            Eiwit = eiwit;
        }
        public override string Beschrijf()
        {
            return base.Beschrijf() + $"Die heeft Eiwit{Eiwit}. ";
        }
       
   }
}
