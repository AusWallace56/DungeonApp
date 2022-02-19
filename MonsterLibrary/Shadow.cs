using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
namespace MonsterLibrary
{
    public class Shadow : Monster
    {
        public Shadow(string name, int life, int maxLife, int hitChance, double critChance, int block, int minDamage, int maxDamage, string description)
           :base(name, life, maxLife, hitChance, block, minDamage, maxDamage, critChance, description) { }

        public Shadow()
        {
            MaxLife = 6;
            MaxDamage = 2;
            Name = "Shadow";
            Life = 14;
            HitChance = 45;
            CritChance = 10;
            Block = 25;
            MinDamage = 1;
            Description = "Never to be seen the Shadow tricks the eyes of even the most percept. Don't turn your back to the light, you never know what could be lurking. ";
        }
    }
}
