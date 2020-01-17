using System;

namespace Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Hero = new Player("Dread Pirate Roberts");
            Enemy goblin = new Enemy("Goblin", 50, 0);
            Enemy Troll = new Enemy("Troll", 150, 0);
            Enemy DarkWizard = new Enemy("Dark Wizard", 100, 100);
            Enemy Wraith = new Enemy("Wraith", 50, 150);
            int playerRoll, enemyRoll;

            Random rand = new Random();

            int RollDice()
            {
                return rand.Next(1, 7);
            }

            Enemy currentEnemy = goblin;
            Player currentPlayer = Hero;

            playerRoll = RollDice();
            enemyRoll = RollDice();

            //for (int i = 0; i < 100; i++)
            //{
            //    playerRoll = RollDice();
            //    enemyRoll = RollDice();
            //    //Console.WriteLine("The two rolls are {0} {1}", playerRoll, enemyRoll);
            //}

            void Fight()
            {
                do
                {
                    do
                    {
                        Console.WriteLine(currentPlayer.GetPlayerHealth(currentPlayer));
                        currentPlayer.takePlayerHealth(currentPlayer, 10);

                        Console.WriteLine(currentEnemy.GetEnemyHealth(currentEnemy));
                        currentEnemy.takeEnemyHealth(currentEnemy, 10);

                    } while (currentPlayer.GetPlayerHealth(currentPlayer) > 0);
                        

                } while (currentEnemy.GetEnemyHealth(currentEnemy) > 0);

                Console.WriteLine("Fight over");
            }

            Fight();

        }






    }
}

