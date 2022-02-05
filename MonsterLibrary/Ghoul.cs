using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
namespace MonsterLibrary
{
    public class Ghoul : Monster
    {
        public Ghoul(string name, int life, int maxLife, int hitChance, double critChance, int block, int minDamage, int maxDamage, string description) 
            : base (name, life, maxLife, hitChance, block, minDamage, maxDamage, critChance, description) { }

        public Ghoul()
        {
            MaxLife = 18;
            MaxDamage = 3;
            Name = "Ghoul";
            Life = 18;
            HitChance = 25;
            CritChance = 4;
            Block = 25;
            MinDamage = 1;
            Description = "With high speeds, razor sharp teeth, and constantly on the hunt for flesh it's best to keep your distance from the Ghoul.";
        }
    }
}
