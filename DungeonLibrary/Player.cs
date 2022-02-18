using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonLibrary
{
    public sealed class Player : Character
    {
        public Race PlayerRace { get; set; }

        public Weapon EquippedWeapon { get; set; }



        public Player(string name, int hitChance, int block, int life, int maxLife, Race playerRace, Weapon equippedWeapon)
        {
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;
        }

        public override string ToString()
        {
            string description = "";

            switch (PlayerRace)
            {
                case Race.HalfGiant:
                    description = "Half Giant";
                    break;
                case Race.Leonin:
                    description = "Leonin";
                    break;
                case Race.Satyr:
                    description = "Satyr";
                    break;
                case Race.Tiefling:
                    description = "Tiefling";
                    break;
                case Race.Human:
                    description = "Human";
                    break;
                case Race.Elf:
                    description = "Elf";
                    break;
                case Race.Dwarf:
                    description = "Dwarf";
                    break;
                default:
                    break;
            }

            return string.Format("~-~-~- {0} -~-~-~\n" +
                "Life: {1} of {2}\n" +
                "Hit Chance: {3}%\n" +
                "Weapon: {4}\n" +
                "Block: {5}\n" +
                "Race: {6}",
                Name, Life, MaxLife, CalcHitChance(), EquippedWeapon, Block, description);
        }

        public override int CalcDamage()
        {
            //return base.CalcDamage();
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.CritChance;
        }

    }
}
