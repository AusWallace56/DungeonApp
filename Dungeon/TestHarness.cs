using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using MonsterLibrary;
namespace Dungeon
{
    class TestHarness
    {
        static void Main(string[] args)
        {
            Console.Title = "Paragons Call";
            Console.WriteLine("How long can you make it before you perish...\n");
            Console.Write("Enter your player name: ");
            string playerName = Console.ReadLine();
            int score = 0;
            int hPotion = 0;
            int gold = 0;
            int silver = 0;
            int copper = 7;
            Weapon Fists = new Weapon(1, 2, "Fists", 0, true);
            Player player = new Player(playerName, 0, 0, 50, 50, Race.Elf, Fists);

            bool raceChoice = false;
            do
            {
                Console.WriteLine("Choose your race.\n\n" +
                    "G) Half Giant\n" +
                    "L) Leonin\n" +
                    "S) Satyr\n" +
                    "T) Tiefling\n" +
                    "H) Human\n" +
                    "E) Elf\n" +
                    "D) Dwarf\n");
                ConsoleKey selectedRace = Console.ReadKey(true).Key;
                switch (selectedRace)
                {
                    case ConsoleKey.G:
                        player = new Player(playerName, 0, 0, 50, 50, Race.HalfGiant, Fists);
                        Console.WriteLine($"{playerName} the Half Giant!\nPress any key to proceed to weapon selection.");
                        Console.ReadKey();
                        Console.Clear();
                        raceChoice = true;
                        bool weaponChoice = false;
                        do
                        {
                            Console.WriteLine("Choose your weapon.\n\n" +
                                "L) Light Hammer\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 4\n" +
                                "Crit Chance: 5%\n" +
                                "Light one handed weapon. Increases Hit Chance, Increases Block, Low Damage.\n\n" +
                                "M) Mace\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 6\n" +
                                "Crit Chance: 5%" +
                                "Average one handed weapon. A standard choice. No effect on stats.\n\n" +
                                "B) Battle Axe\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 8\n" +
                                "Crit Chance: 7%\n" +
                                "Two handed weapon. Decrease to Block, but rewards with heavier damage.\n\n" +
                                "G) Glaive\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 10\n" +
                                "Crit Chance: 10%\n" +
                                "Heavy two handed weapon. Decrease to Block, decrease to Hit Chance, but offers killer blows.");

                            ConsoleKey selectedWeapon = Console.ReadKey(true).Key;
                            Console.Clear();
                            switch (selectedWeapon)
                            {

                                case ConsoleKey.L:
                                    Weapon lightHammer = new Weapon(1, 4, "Light Hammer", 5, false);
                                    player = new Player(playerName, 48, 23, 50, 50, Race.HalfGiant, lightHammer);
                                    Console.WriteLine("You have selected the Light Hammer.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.M:
                                    Weapon Mace = new Weapon(1, 6, "Mace", 5, false);
                                    player = new Player(playerName, 45, 20, 50, 50, Race.HalfGiant, Mace);
                                    Console.WriteLine("You have selected the Mace.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.B:
                                    Weapon battleAxe = new Weapon(2, 8, "Battle Axe", 7, true);
                                    player = new Player(playerName, 45, 18, 50, 50, Race.HalfGiant, battleAxe);
                                    Console.WriteLine("You have selected the Battle Axe.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.G:
                                    Weapon Glaive = new Weapon(2, 10, "Glaive", 10, true);
                                    player = new Player(playerName, 38, 17, 50, 50, Race.HalfGiant, Glaive);
                                    Console.WriteLine("You have selected the Glaive.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input selected. Try another key.");
                                    break;
                            }


                        } while (!weaponChoice && !raceChoice);
                        break;
                    case ConsoleKey.L:
                        player = new Player(playerName, 0, 0, 50, 50, Race.Leonin, Fists);
                        Console.WriteLine($"{playerName} the Leonin!\nPress any key to proceed to weapon selection.");
                        Console.ReadKey();
                        Console.Clear();
                        raceChoice = true;
                        bool weaponChoice2 = false;
                        do
                        {
                            Console.WriteLine("Choose your weapon.\n\n" +
                                "L) Light Hammer\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 4\n" +
                                "Crit Chance: 5%\n" +
                                "Light one handed weapon. Increases Hit Chance, Increases Block, Low Damage.\n\n" +
                                "M) Mace\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 6\n" +
                                "Crit Chance: 5%" +
                                "Average one handed weapon. A standard choice. No effect on stats.\n\n" +
                                "B) Battle Axe\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 8\n" +
                                "Crit Chance: 7%\n" +
                                "Two handed weapon. Decrease to Block, but rewards with heavier damage.\n\n" +
                                "G) Glaive\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 10\n" +
                                "Crit Chance: 10%\n" +
                                "Heavy two handed weapon. Decrease to Block, decrease to Hit Chance, but offers killer blows.");

                            ConsoleKey selectedWeapon = Console.ReadKey(true).Key;
                            Console.Clear();
                            switch (selectedWeapon)
                            {

                                case ConsoleKey.L:
                                    Weapon lightHammer = new Weapon(1, 4, "Light Hammer", 5, false);
                                    player = new Player(playerName, 48, 23, 50, 50, Race.Leonin, lightHammer);
                                    Console.WriteLine("You have selected the Light Hammer.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.M:
                                    Weapon Mace = new Weapon(1, 6, "Mace", 5, false);
                                    player = new Player(playerName, 45, 20, 50, 50, Race.Leonin, Mace);
                                    Console.WriteLine("You have selected the Mace.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.B:
                                    Weapon battleAxe = new Weapon(2, 8, "Battle Axe", 7, true);
                                    player = new Player(playerName, 45, 18, 50, 50, Race.Leonin, battleAxe);
                                    Console.WriteLine("You have selected the Battle Axe.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.G:
                                    Weapon Glaive = new Weapon(2, 10, "Glaive", 10, true);
                                    player = new Player(playerName, 38, 17, 50, 50, Race.Leonin, Glaive);
                                    Console.WriteLine("You have selected the Glaive.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input selected. Try another key.");
                                    break;
                            }


                        } while (!weaponChoice2 && !raceChoice);
                        break;
                    case ConsoleKey.S:
                        player = new Player(playerName, 0, 0, 50, 50, Race.Satyr, Fists);
                        Console.WriteLine($"{playerName} the Satyr!\nPress any key to proceed to weapon selection.");
                        Console.ReadKey();
                        Console.Clear();
                        raceChoice = true;
                        bool weaponChoice3 = false;
                        do
                        {
                            Console.WriteLine("Choose your weapon.\n\n" +
                                "L) Light Hammer\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 4\n" +
                                "Crit Chance: 5%\n" +
                                "Light one handed weapon. Increases Hit Chance, Increases Block, Low Damage.\n\n" +
                                "M) Mace\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 6\n" +
                                "Crit Chance: 5%" +
                                "Average one handed weapon. A standard choice. No effect on stats.\n\n" +
                                "B) Battle Axe\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 8\n" +
                                "Crit Chance: 7%\n" +
                                "Two handed weapon. Decrease to Block, but rewards with heavier damage.\n\n" +
                                "G) Glaive\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 10\n" +
                                "Crit Chance: 10%\n" +
                                "Heavy two handed weapon. Decrease to Block, decrease to Hit Chance, but offers killer blows.");

                            ConsoleKey selectedWeapon = Console.ReadKey(true).Key;
                            Console.Clear();
                            switch (selectedWeapon)
                            {

                                case ConsoleKey.L:
                                    Weapon lightHammer = new Weapon(1, 4, "Light Hammer", 5, false);
                                    player = new Player(playerName, 48, 23, 50, 50, Race.Satyr, lightHammer);
                                    Console.WriteLine("You have selected the Light Hammer.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.M:
                                    Weapon Mace = new Weapon(1, 6, "Mace", 5, false);
                                    player = new Player(playerName, 45, 20, 50, 50, Race.Satyr, Mace);
                                    Console.WriteLine("You have selected the Mace.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.B:
                                    Weapon battleAxe = new Weapon(2, 8, "Battle Axe", 7, true);
                                    player = new Player(playerName, 45, 18, 50, 50, Race.Satyr, battleAxe);
                                    Console.WriteLine("You have selected the Battle Axe.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.G:
                                    Weapon Glaive = new Weapon(2, 10, "Glaive", 10, true);
                                    player = new Player(playerName, 38, 17, 50, 50, Race.Satyr, Glaive);
                                    Console.WriteLine("You have selected the Glaive.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input selected. Try another key.");
                                    break;
                            }


                        } while (!weaponChoice3 && !raceChoice);
                        break;
                    case ConsoleKey.T:
                        player = new Player(playerName, 0, 0, 50, 50, Race.Tiefling, Fists);
                        Console.WriteLine($"{playerName} the Tiefling!\nPress any key to proceed to weapon selection.");
                        Console.ReadKey();
                        Console.Clear();
                        raceChoice = true;
                        bool weaponChoice4 = false;
                        do
                        {
                            Console.WriteLine("Choose your weapon.\n\n" +
                                "L) Light Hammer\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 4\n" +
                                "Crit Chance: 5%\n" +
                                "Light one handed weapon. Increases Hit Chance, Increases Block, Low Damage.\n\n" +
                                "M) Mace\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 6\n" +
                                "Crit Chance: 5%" +
                                "Average one handed weapon. A standard choice. No effect on stats.\n\n" +
                                "B) Battle Axe\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 8\n" +
                                "Crit Chance: 7%\n" +
                                "Two handed weapon. Decrease to Block, but rewards with heavier damage.\n\n" +
                                "G) Glaive\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 10\n" +
                                "Crit Chance: 10%\n" +
                                "Heavy two handed weapon. Decrease to Block, decrease to Hit Chance, but offers killer blows.");

                            ConsoleKey selectedWeapon = Console.ReadKey(true).Key;
                            Console.Clear();
                            switch (selectedWeapon)
                            {

                                case ConsoleKey.L:
                                    Weapon lightHammer = new Weapon(1, 4, "Light Hammer", 5, false);
                                    player = new Player(playerName, 48, 23, 50, 50, Race.Tiefling, lightHammer);
                                    Console.WriteLine("You have selected the Light Hammer.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.M:
                                    Weapon Mace = new Weapon(1, 6, "Mace", 5, false);
                                    player = new Player(playerName, 45, 20, 50, 50, Race.Tiefling, Mace);
                                    Console.WriteLine("You have selected the Mace.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.B:
                                    Weapon battleAxe = new Weapon(2, 8, "Battle Axe", 7, true);
                                    player = new Player(playerName, 45, 18, 50, 50, Race.Tiefling, battleAxe);
                                    Console.WriteLine("You have selected the Battle Axe.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.G:
                                    Weapon Glaive = new Weapon(2, 10, "Glaive", 10, true);
                                    player = new Player(playerName, 38, 17, 50, 50, Race.Tiefling, Glaive);
                                    Console.WriteLine("You have selected the Glaive.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input selected. Try another key.");
                                    break;
                            }


                        } while (!weaponChoice4 && !raceChoice);
                        break;
                    case ConsoleKey.H:
                        player = new Player(playerName, 0, 0, 50, 50, Race.Human, Fists);
                        Console.WriteLine($"{playerName} the Human!\nPress any key to proceed to weapon selection.");
                        Console.ReadKey();
                        Console.Clear();
                        raceChoice = true;
                        bool weaponChoice5 = false;
                        do
                        {
                            Console.WriteLine("Choose your weapon.\n\n" +
                                "L) Light Hammer\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 4\n" +
                                "Crit Chance: 5%\n" +
                                "Light one handed weapon. Increases Hit Chance, Increases Block, Low Damage.\n\n" +
                                "M) Mace\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 6\n" +
                                "Crit Chance: 5%" +
                                "Average one handed weapon. A standard choice. No effect on stats.\n\n" +
                                "B) Battle Axe\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 8\n" +
                                "Crit Chance: 7%\n" +
                                "Two handed weapon. Decrease to Block, but rewards with heavier damage.\n\n" +
                                "G) Glaive\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 10\n" +
                                "Crit Chance: 10%\n" +
                                "Heavy two handed weapon. Decrease to Block, decrease to Hit Chance, but offers killer blows.");

                            ConsoleKey selectedWeapon = Console.ReadKey(true).Key;
                            Console.Clear();
                            switch (selectedWeapon)
                            {

                                case ConsoleKey.L:
                                    Weapon lightHammer = new Weapon(1, 4, "Light Hammer", 5, false);
                                    player = new Player(playerName, 48, 23, 50, 50, Race.Human, lightHammer);
                                    Console.WriteLine("You have selected the Light Hammer.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.M:
                                    Weapon Mace = new Weapon(1, 6, "Mace", 5, false);
                                    player = new Player(playerName, 45, 20, 50, 50, Race.Human, Mace);
                                    Console.WriteLine("You have selected the Mace.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.B:
                                    Weapon battleAxe = new Weapon(2, 8, "Battle Axe", 7, true);
                                    player = new Player(playerName, 45, 18, 50, 50, Race.Human, battleAxe);
                                    Console.WriteLine("You have selected the Battle Axe.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.G:
                                    Weapon Glaive = new Weapon(2, 10, "Glaive", 10, true);
                                    player = new Player(playerName, 38, 17, 50, 50, Race.Human, Glaive);
                                    Console.WriteLine("You have selected the Glaive.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input selected. Try another key.");
                                    break;
                            }
                        } while (!weaponChoice5 && !raceChoice);
                        break;
                    case ConsoleKey.E:
                        player = new Player(playerName, 0, 0, 50, 50, Race.Elf, Fists);
                        Console.WriteLine($"{playerName} the Elf!\nPress any key to proceed to weapon selection.");
                        Console.ReadKey();
                        Console.Clear();
                        raceChoice = true;
                        bool weaponChoice6 = false;
                        do
                        {
                            Console.WriteLine("Choose your weapon.\n\n" +
                                "L) Light Hammer\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 4\n" +
                                "Crit Chance: 5%\n" +
                                "Light one handed weapon. Increases Hit Chance, Increases Block, Low Damage.\n\n" +
                                "M) Mace\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 6\n" +
                                "Crit Chance: 5%" +
                                "Average one handed weapon. A standard choice. No effect on stats.\n\n" +
                                "B) Battle Axe\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 8\n" +
                                "Crit Chance: 7%\n" +
                                "Two handed weapon. Decrease to Block, but rewards with heavier damage.\n\n" +
                                "G) Glaive\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 10\n" +
                                "Crit Chance: 10%\n" +
                                "Heavy two handed weapon. Decrease to Block, decrease to Hit Chance, but offers killer blows.");

                            ConsoleKey selectedWeapon = Console.ReadKey(true).Key;
                            Console.Clear();
                            switch (selectedWeapon)
                            {

                                case ConsoleKey.L:
                                    Weapon lightHammer = new Weapon(1, 4, "Light Hammer", 5, false);
                                    player = new Player(playerName, 48, 23, 50, 50, Race.Elf, lightHammer);
                                    Console.WriteLine("You have selected the Light Hammer.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.M:
                                    Weapon Mace = new Weapon(1, 6, "Mace", 5, false);
                                    player = new Player(playerName, 45, 20, 50, 50, Race.Elf, Mace);
                                    Console.WriteLine("You have selected the Mace.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.B:
                                    Weapon battleAxe = new Weapon(2, 8, "Battle Axe", 7, true);
                                    player = new Player(playerName, 45, 18, 50, 50, Race.Elf, battleAxe);
                                    Console.WriteLine("You have selected the Battle Axe.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.G:
                                    Weapon Glaive = new Weapon(2, 10, "Glaive", 10, true);
                                    player = new Player(playerName, 38, 17, 50, 50, Race.Elf, Glaive);
                                    Console.WriteLine("You have selected the Glaive.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input selected. Try another key.");
                                    break;
                            }
                        } while (!weaponChoice6 && !raceChoice);
                        break;
                    case ConsoleKey.D:
                        player = new Player(playerName, 0, 0, 50, 50, Race.Dwarf, Fists);
                        Console.WriteLine($"{playerName} the Dwarf!\nPress any key to proceed to weapon selection.");
                        Console.ReadKey();
                        Console.Clear();
                        raceChoice = true;
                        bool weaponChoice7 = false;
                        do
                        {
                            Console.WriteLine("Choose your weapon.\n\n" +
                                "L) Light Hammer\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 4\n" +
                                "Crit Chance: 5%\n" +
                                "Light one handed weapon. Increases Hit Chance, Increases Block, Low Damage.\n\n" +
                                "M) Mace\n" +
                                "Min Damage: 1\n" +
                                "Max Damage: 6\n" +
                                "Crit Chance: 5%" +
                                "Average one handed weapon. A standard choice. No effect on stats.\n\n" +
                                "B) Battle Axe\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 8\n" +
                                "Crit Chance: 7%\n" +
                                "Two handed weapon. Decrease to Block, but rewards with heavier damage.\n\n" +
                                "G) Glaive\n" +
                                "Min Damage: 2\n" +
                                "Max Damage: 10\n" +
                                "Crit Chance: 10%\n" +
                                "Heavy two handed weapon. Decrease to Block, decrease to Hit Chance, but offers killer blows.");

                            ConsoleKey selectedWeapon = Console.ReadKey(true).Key;
                            Console.Clear();
                            switch (selectedWeapon)
                            {

                                case ConsoleKey.L:
                                    Weapon lightHammer = new Weapon(1, 4, "Light Hammer", 5, false);
                                    player = new Player(playerName, 48, 23, 50, 50, Race.Dwarf, lightHammer);
                                    Console.WriteLine("You have selected the Light Hammer.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.M:
                                    Weapon Mace = new Weapon(1, 6, "Mace", 5, false);
                                    player = new Player(playerName, 45, 20, 50, 50, Race.Dwarf, Mace);
                                    Console.WriteLine("You have selected the Mace.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.B:
                                    Weapon battleAxe = new Weapon(2, 8, "Battle Axe", 7, true);
                                    player = new Player(playerName, 45, 18, 50, 50, Race.Dwarf, battleAxe);
                                    Console.WriteLine("You have selected the Battle Axe.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                case ConsoleKey.G:
                                    Weapon Glaive = new Weapon(2, 10, "Glaive", 10, true);
                                    player = new Player(playerName, 38, 17, 50, 50, Race.Dwarf, Glaive);
                                    Console.WriteLine("You have selected the Glaive.\nPress any key to start your journey.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    weaponChoice = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input selected. Try another key.");
                                    break;
                            }
                        } while (!weaponChoice7 && !raceChoice);
                        break;
                    default:
                        Console.WriteLine("Wrong input selected. Try another key.");
                        break;
                }
            } while (!raceChoice);

           

            bool exit = false;


            do
            {
                Console.WriteLine(GetRoom());

                Ghoul g1 = new Ghoul();

                Grimlock gr1 = new Grimlock();

                Shadow s1 = new Shadow();

                Boneless t1 = new Boneless();

                Monster[] monsters = { g1, g1, gr1, gr1, s1, s1, t1, t1 };

                Random rand = new Random();

                int randomNbr = rand.Next(monsters.Length);

                Monster monster = monsters[randomNbr];

                Console.WriteLine("\n You encounter a " + monster.Name);

                bool reload = false;

                do
                {
                    Console.WriteLine("\nChoose your action:\n" +
                        "A) Attack\n" +
                        "F) Flee\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "L) Loot Room\n" +
                        "I) Inventory\n" +
                        "H) Consume Health Potion\n" +
                        "E) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Combat.DoBattle(player, monster);

                            if (monster.Life <=0)
                            {
                                
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\n You have slain {0}!\n", monster.Name);
                                Console.ResetColor();
                                reload = true;
                                score++;
                            }
                            break;
                        case ConsoleKey.F:
                            Console.WriteLine("You make an attempt to escape.");
                            Console.WriteLine("{0} attacks you as you flee!", monster.Name);
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();
                            reload = true;
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Information");
                            Console.WriteLine(player);
                            Console.WriteLine($"Monsters Defeated: {score}\n\n");
                            reload = true;
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster Information");
                            Console.WriteLine(monster);
                            reload = true;
                            break;
                        case ConsoleKey.E:
                        case ConsoleKey.X:
                            Console.WriteLine("Running away from your fears... cowardly");
                            exit = true;
                            break;
                        case ConsoleKey.L:
                            Random randHealth = new Random();
                            int healthRoll = randHealth.Next(1, 101);

                            Random coinRoll = new Random();
                            int coinAdded = coinRoll.Next(1, 37);

                            Random randCopper = new Random();
                            int copperRoll = randCopper.Next(1, 101);

                            Random randSilver = new Random();
                            int silverRoll = randSilver.Next(1, 101);

                            Random randGold = new Random();
                            int goldRoll = randGold.Next(1, 101);
                            if (healthRoll <= 20)
                            {
                                hPotion++;
                                Console.WriteLine("You found a health potion. Lucky you!");
                            }
                            else
                            {
                                Console.WriteLine("No health potions were found.");
                            }
                             if (goldRoll <= 30)
                            {
                                Console.WriteLine($"You found {coinAdded} Gold.");
                                gold += coinAdded;
                            }
                            else
                            {
                                Console.WriteLine("No gold was found.");
                            }
                            if (silverRoll <= 40)
                            {
                                Console.WriteLine($"You found {coinAdded} Silver.");
                                silver += coinAdded;
                            }
                            else
                            {
                                Console.WriteLine("No silver was found.");
                            }
                            if (copperRoll <= 65)
                            {
                                Console.WriteLine($"You found {coinAdded} Copper.");
                                copper += coinAdded;
                            }
                            else
                            {
                                Console.WriteLine("No Copper was found.");
                            }
                            reload = true;
                            break;
                        case ConsoleKey.I:
                            Console.WriteLine($"Gold: {gold}");
                            Console.WriteLine($"Silver: {silver}");
                            Console.WriteLine($"Copper: {copper}");
                            Console.WriteLine($"Health Potions: {hPotion}\n\n");
                            reload = true;
                            break;
                        case ConsoleKey.H:
                            Random healing = new Random();
                            int heal = healing.Next(8, 16);
                            if (hPotion >= 1 )
                            {
                                Console.WriteLine($"You have consumed a health potion and healed for {heal} points.");
                                player.Life += heal;
                                hPotion--;
                            }
                            else
                            {
                                Console.WriteLine("You must find health potions before you can consume them.");
                            }
                            break;
                        default:
                            Console.WriteLine("Wrong input selected. Try another key.");
                            break;
                    }

                    if (player.Life <=0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("YOU DIED");
                        Console.ResetColor();
                        exit = true;
                    }

                } while (!reload && !exit);

            } while (!exit);
            Console.WriteLine("You defeated " + score + " monster" + ((score == 1) ? "." : "s."));
        }
    
        private static string GetRoom()
        {
            string[] rooms = {

                "A dim bluish light suffuses this chamber, its source obvious at a glance. Blue-glowing lichen and violet-glowing moss cling to the ceiling and spread across the floor. It even creeps down and up each wall, as if the colonies on the floor and ceiling are growing to meet each other. Their source seems to be a glowing, narrow crack in the ceiling, the extent of which you cannot gauge from your position. The air in the room smells fresh and damp.",
                " Huge rusted metal blades jut out of cracks in the walls, and rusting spikes project down from the ceiling almost to the floor. This room may have once been trapped heavily, but someone triggered them, apparently without getting killed. The traps were never reset and now seem rusted in place.",
                "Burning torches in iron sconces line the walls of this room, lighting it brilliantly. At the room's center lies a squat stone altar, its top covered in recently spilled blood. A channel in the altar funnels the blood down its side to the floor where it fills grooves in the floor that trace some kind of pattern or symbol around the altar. Unfortunately, you can't tell what it is from your vantage point.",
                "Every surface bears scorch marks and ash piles on the floor. The room reeks of fire and burnt flesh. Either a great battle happened here or the room bears some fire danger you cannot see for no flames light the room anymore.",
                "Several round pits lie in the floor of the room before you. Spaced roughly equally apart, each is about 15 feet in diameter and appears about 20 feet deep. A lattice of thick iron bars covers the top of each pit, and each lattice has a door of iron bars that can be lifted open. The pits smell of sweat and offal, but the room seems unoccupied.",
                " A glow escapes this room through its open doorways. The masonry between every stone emanates an unnatural orange radiance. Glancing quickly about the room, you note that each stone bears the carving of someone's name.",
                " A horrendous, overwhelming stench wafts from the room before you. Small cages containing small animals and large insects line the walls. Some of the creatures look sickly and alive but most are clearly dead. Their rotting corpses and the unclean cages no doubt result in the zoo's foul odor. A cat mews weakly from its cage, but the other creatures just silently shrink back into their filthy prisons.",
                " A strange ceiling is the focal point of the room before you. It's honeycombed with hundreds of holes about as wide as your head. They seem to penetrate the ceiling to some height beyond a couple feet, but you can't be sure from your vantage point.",
                "You open the door, and the reek of garbage assaults your nose. Looking inside, you see a pile of refuse and offal that nearly reaches the ceiling. In the ceiling above it is a small hole that is roughly as wide as two human hands. No doubt some city dweller high above disposes of his rubbish without ever thinking about where it goes.",
                " You peer into this room and spot the white orb of a skull lying on the floor. Suddenly a stone falls from the ceiling and smashes the skull to pieces. An instant later, another stone from the ceiling drops to strike the floor and shatter. You hear a low rumbling and cracking noise.",
                "This short hall leads to another door. On either side of the hall, niches are set into the wall within which stand clay urns. One of the urns has been shattered, and its contents have spilled onto its shelf and the floor. Amid the ash it held, you see blackened chunks of something that might be bone.",
                "This room looks like it was designed by drow. Rusted metal tiles create a huge mosaic of a spider in the floor, and someone set up rusted gratings like draperies of webs. At the far end of the chamber, the carving of a spider squats on the floor. It's about 3 feet tall and seems molded into the floor. Beyond it stands tall double doors of stone, their surface covered in a glittering web of gold.",
                "This chamber is clearly a prison. Small barred cells line the walls, leaving a 15-foot-wide pathway for a guard to walk. Channels run down either side of the path next to the cages, probably to allow the prisoners' waste to flow through the grates on the other side of the room. The cells appear empty but your vantage point doesn't allow you to see the full extent of them all.",
                "You find this chamber lit dimly by guttering candles that squat in small hills of melted wax. The smell of their smoke hits your nose along with an odor that is reminiscent of the sea. Someone has taken a large amount of salt and drawn a broad circular symbol on the floor with the candles situated equidistantly around it. Atop the salt, someone traced the symbol with a black powder that glints a dull silver in the candlelight.",
                "Corpses and pieces of corpses hang from hooks that dangle from chains attached to thick iron rings. Most appear humanoid but a few of the body parts appear more monstrous. You don't see any heads, hands, or feet -- all seem to have been chopped or torn off. Neither do you see any guts in the horrible array, but several thick leather sacks hang from hooks in the walls, and they are suspiciously wet and the leather looks extremely taut -- as if it' under great strain.",
                "This room is a tomb. Stone sarcophagi stand in five rows of three, each carved with the visage of a warrior lying in state. In their center, one sarcophagus stands taller than the rest. Held up by six squat pillars, its stone bears the carving of a beautiful woman who seems more asleep than dead. The carving of the warriors is skillful but seems perfunctory compared to the love a sculptor must have lavished upon the lifelike carving of the woman.",
                "This room smells strange, no doubt due to the weird sheets of black slime that drip from cracks in the ceiling and spread across the floor. The slime seeps from the shattered stone of the ceiling at a snails crawl, forming a mess of dangling walls of gook. As you watch, a bit of the stuff separates from a sheet and drops to the ground with a wet plop.",
                "Rounded green stones set in the floor form a snake's head that points in the direction of the doorway you stand in. The body of the snake flows back and toward the wall to go round about the room in ever smaller circles, creating a spiral pattern on the floor. Similar green-stone snakes wend along the walls, seemingly at random heights, and their long bodies make wave shapes."

            };
            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;
        }

    }
}
