using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character 
    {
        private int _minDamage;

        public int MaxDamage { get; set; }

        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <=MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 2;
                }
            }
        }

        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, double critChance, string description)
        {
            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Name = name;
            Life = life;
            HitChance = hitChance;
            CritChance = critChance;
            Block = block;
            MinDamage = minDamage;
            Description = description;
        }
        public Monster() { }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("~=~=~=~=~ MONSTER ~=~=~=~=~\n" +
                "{0}\n" +
                "Life: {1} of {2}\n" +
                "Damage: {3} to {4}\n" +
                "Crit Chance: {5}%\n" +
                "Hit Chance: {6}\n" +
                "Block: {7}\n" +
                "Description: {8}",
                Name,
                Life,
                MaxLife,
                MinDamage,
                MaxDamage,
                CritChance,
                HitChance,
                Block,
                Description);
        }
        

        public override int CalcDamage()
        {
            //return base.CalcDamage();
            Random rand = new Random();

            return rand.Next(MinDamage, MaxDamage + 1);
        }

    }
}
