using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overervingclasses
{
    public class Eten
    {
        public string Naam { get; set; }
        public string Kleur { get; set; }
        public List<string> Voedingsstoffen{ get; set; }

        public Eten(string naam, string kleur, List<string> voedingsstoffen)
        {
            Naam = naam;
            Kleur = kleur;
            Voedingsstoffen = voedingsstoffen;
        }
        public Eten(string naam, string kleur)
        {
            Naam = naam;
            Kleur = kleur;
            Voedingsstoffen = new List<string>();
        }

        public virtual string Beschrijf()
        {
            string beschrijving;

            if (Voedingsstoffen.Count != 0)
            {
                beschrijving = $"Deze Eten heet {Naam}.Zijn kleur is {Kleur} met de Voedingsstoffen";

                foreach (var item in Voedingsstoffen)
                {
                    beschrijving += " " + item;
                }

                beschrijving += ". ";
            }
            else
            {
                beschrijving = $"Deze Eten  heet {Naam}. Zijn kleur is {Kleur}. ";
            }

            return beschrijving;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
