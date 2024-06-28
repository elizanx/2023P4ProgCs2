using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Skill
    {
        public int damage { get; set; }
        public int energyCost { get; set; }
        public string[] name { get; set; }
        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);

            if (target.weakness == element)
            {
                target.TakeDamage(damage/2);
            }
        }

        public Element element { get; set; }




    }
}
