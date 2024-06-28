using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMon
    {
        public int health { get; set; }
        public int energy { get; set; }
        public string name { get; set; }

        private List<Skill> skills = new List<Skill>();

        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }

        public Element weakness { get; set; }

    }
}
