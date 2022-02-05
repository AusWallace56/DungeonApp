using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Grimlock : Monster
    {
        public Grimlock(string name, int life, int maxLife, int hitChance, double critChance, int block, int minDamage, int maxDamage, string description)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, critChance, description) { }


        public Grimlock()
        {
            MaxLife = 12;
            MaxDamage = 6;
            Name = "Grimlock";
            Life = 12;
            HitChance = 16;
            CritChance = 1;
            Block = 4;
            MinDamage = 3;
            Description = "The Grimlock. Naturally evil. Blind, but don't let that fool you. With a keen sense of smell it can pick out it's opponents.";
        }
    }
}
