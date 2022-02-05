using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class TheBoneless : Monster
    {
        public TheBoneless(string name, int life, int maxLife, int hitChance, double critChance, int block, int minDamage, int maxDamage, string description)
           : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, critChance, description) { }

        public TheBoneless()
        {
            MaxLife = 8;
            MaxDamage = 8;
            Name = "The Boneless";
            Life = 8;
            HitChance = 50;
            CritChance = 5;
            Block = 35;
            MinDamage = 2;
            Description = "An undead sack of humanoid flesh clinging on to necromatic magic that holds it to this plane.";
        }
    }
}
