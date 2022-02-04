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


       // public Grimlock()
       // {
       //     MaxLife = 12;
       //     MaxDamage = 6;
       //     Name = "Grimlock";
       //     Life = 12;
       //     HitChance = 5;
       //     Block = 4;
       //     MinDamage = 3;
       //     Description = "s";
       // }
    }
}
