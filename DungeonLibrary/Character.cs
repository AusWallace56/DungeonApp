using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //Fields
        private int _life;

        //Properties
        public string Name { get; set; }

        public int HitChance { get; set; }

        public int Block { get; set; }

        public int MaxLife { get; set; }

        public double CritChance { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }
        //Ctors
        //No ctors due to being an abstract class.
        //Methods

        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }

        public virtual double CalcCritChance()
        {
            return CritChance;
        }
    }
}
