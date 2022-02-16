using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(40);

            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                int dealDamage = attacker.CalcDamage();

                defender.Life -= dealDamage;

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, dealDamage);
                Console.ResetColor();
            }

            else
            {
                Console.WriteLine("{0} missed!", attacker.Name);
            }

        }

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);

            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }
    }
}
