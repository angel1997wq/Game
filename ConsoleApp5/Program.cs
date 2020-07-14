using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, choose hero.\n 1.Human\n 2.Orc\n 3.Elf\n Choose a Number for your class 1 , 2 , 3");
            int Human = 1;
            int Elf = 3;
            int Orc = 2;
            int Number = int.Parse(Console.ReadLine());
            if (Number == 1)
            {

                Console.WriteLine("You choose Human");
            }
            if (Number == 2)
            {
                Console.WriteLine("You choose Orc");
            }
            if (Number == 3)
            {
                Console.WriteLine("You choose Elf");
            }
         
            Console.WriteLine("Choose your specialization.\n 1. Warrior \n 2. Hunter\n 3. Mage\n");
            Console.WriteLine("Choose 1 , 2 or 3 for specialization");
            int Warrior = 1;
            int Hunter = 2;
            int Mage = 3;

            int Number1 = int.Parse(Console.ReadLine());
            if (Number1 == 1)
            {

                Console.WriteLine("Your specialization is Warrior");
                Console.WriteLine("The Warrior is using axe to fight, he is mele.");

            }
            if (Number1 == 2)
            {
                Console.WriteLine("Your specialization is Hunter");
                Console.WriteLine("The Hunter is using arrows to fight, he is range.");
            }
            if (Number1 == 3)
            {
                Console.WriteLine("Your specialization is Mage");
                Console.WriteLine("The mage use spells to fight, he is range.");
            }

            Console.WriteLine("You are level 1 in Dalaran.");
            Console.WriteLine("Choose where do you want to go to Level UP.\n 1. Stormwind forest(recommended for level 1 to level 5.) " +
                 "\n 2. Drustvar(recommended level 5 to level 10.) \n 3. Halls of Origination(recommended level 10 to max level 15.)");
            int Stormwind = 1;
            int Drustvar = 2;
            int Halls = 3;
            int HeroLevel = 1;
            while (HeroLevel <= 14)
            {
                int Number2 = int.Parse(Console.ReadLine());
                if (Number2 == 1)
                {

                    Console.WriteLine("You are in Stormwind forest.");


                    while (HeroLevel < 5)
                    {

                        int monster = 5;
                        Console.WriteLine("There is a monster Elf.");
                        Console.WriteLine("Monster Have 5 Health");
                        Console.WriteLine("Choose 1 to attack");

                        int attack1 = int.Parse(Console.ReadLine());
                        while (attack1 > 0 && attack1 <= 5)
                        {

                            Console.WriteLine("Monster have {0} health.", monster - 1);
                            attack1++;
                            monster--;
                        }
                        Console.WriteLine("The monster is Dead.");
                        HeroLevel++;
                        Console.WriteLine("You are level " + HeroLevel);
                        Console.WriteLine("Kill Monsters until you reach level ");
                    }

                }
                if (Number2 == 2)
                {
                    Console.WriteLine("You are in Drustvar");
                    while (HeroLevel < 10 && HeroLevel >= 5)
                    {

                        int monster = 10;
                        Console.WriteLine("There is a monster Dragon.");
                        Console.WriteLine("Monster Have 10 Health");
                        Console.WriteLine("Choose 1 to attack");

                        int attack1 = int.Parse(Console.ReadLine());
                        while (attack1 > 0 && attack1 <= 10)
                        {

                            Console.WriteLine("Monster have {0} health.", monster - 1);
                            attack1++;
                            monster--;
                        }
                        Console.WriteLine("The monster is Dead.");
                        HeroLevel++;
                        Console.WriteLine("You are level " + HeroLevel);
                        Console.WriteLine("Kill Monsters until you reach level 10");
                    }
                }
                if (Number2 == 3)
                {
                    Console.WriteLine("You are in Drustvar");
                    while (HeroLevel <= 14 && HeroLevel >= 10)
                    {

                        int monster = 15;
                        Console.WriteLine("There is a monster  Two head Dragon.");
                        Console.WriteLine("Monster Have 15 Health");
                        Console.WriteLine("Choose 1 to attack");

                        int attack1 = int.Parse(Console.ReadLine());
                        while (attack1 > 0 && attack1 <= 15)
                        {

                            Console.WriteLine("Monster have {0} health.", monster - 1);
                            attack1++;
                            monster--;
                        }
                        Console.WriteLine("The monster is Dead.");
                        HeroLevel++;
                        Console.WriteLine("You are level " + HeroLevel);
                        Console.WriteLine("Kill Monsters until you reach level 15");
                    }
                   

                }
                Console.WriteLine("Choose other map for your level");
                Console.WriteLine("Your level is " + HeroLevel);
                Console.WriteLine("Choose where do you want to go to Level UP.\n 1. Stormwind forest(recommended for level 1 to level 5.) " +
                 "\n 2. Drustvar(recommended level 5 to level 10.) \n 3. Halls of Origination(recommended level 10 to max level 15.)");

            }
            Console.WriteLine("Great Job you are now max level");
        }
    }
}
