using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        private int _minDamage;

        public int MaxDamage { get; set; }

        public string Name { get; set; }

        public int CritChance { get; set; }

        public bool IsTwoHanded { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }

        }
        public Weapon(int minDamage, int maxDamage, string name, int critChance, bool isTwoHanded)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            CritChance = critChance;
            IsTwoHanded = isTwoHanded;
        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Crit Chance: {3}%",
                Name,
                MinDamage,
                MaxDamage,
                CritChance,
                IsTwoHanded ? "Two-Handed" : "One-Handed");
        }



    }
}
