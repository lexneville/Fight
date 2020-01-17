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

            int RollDice(int maxValue)
            {
                return rand.Next(1, maxValue);
            }

            Enemy currentEnemy = goblin;
            Player currentPlayer = Hero;

            playerRoll = RollDice(6);
            enemyRoll = RollDice(6);

            //for (int i = 0; i < 100; i++)
            //{
            //    playerRoll = RollDice();
            //    enemyRoll = RollDice();
            //    //Console.WriteLine("The two rolls are {0} {1}", playerRoll, enemyRoll);
            //}

            void Fight()
            {
                Console.WriteLine($"You encounter a {currentEnemy.GetEnemyName(currentEnemy)}");

                do
                {
                    Console.WriteLine("Hit a key to roll the dice!");
                    Console.WriteLine("If you roll higher than the enemy rolls, your strike is successful");
                    Console.ReadKey();
                    Console.WriteLine();
                    playerRoll = RollDice(6);
                    enemyRoll = RollDice(6);



                    // string playerChoices = "";



                    if (playerRoll > enemyRoll)
                    {
                        Console.WriteLine($"{currentPlayer.GetPlayerName(currentPlayer)} has rolled {playerRoll}, the {currentEnemy.GetEnemyName(currentEnemy)} has rolled {enemyRoll}");
                        Console.WriteLine($"{currentPlayer.GetPlayerName(currentPlayer)} wins the roll, the attack was successful!" );
                        Console.WriteLine("Hit a key to roll a D12 for damage amount");
                        int playerDamageRoll = RollDice(12);
                        Console.WriteLine($"{currentEnemy.GetEnemyName(currentEnemy)}'s health has been reduced by {playerDamageRoll} HP");
                        currentEnemy.TakeEnemyHealth(currentEnemy, playerDamageRoll);
                        Console.WriteLine($"The {currentEnemy.GetEnemyName(currentEnemy)} now has {currentEnemy.GetEnemyHealth(currentEnemy)} HP");
                    }
                    else if (playerRoll < enemyRoll)
                    {
                        Console.WriteLine($"{currentPlayer.GetPlayerName(currentPlayer)} has rolled {playerRoll}, the {currentEnemy.GetEnemyName(currentEnemy)} has rolled {enemyRoll}");
                        Console.WriteLine($"{currentEnemy.GetEnemyName(currentEnemy)} wins the roll, the attack was successful!");
                        Console.WriteLine($"The {currentEnemy.GetEnemyName(currentEnemy)} rolls a D12 for damage");
                        int enemyDamageRoll = RollDice(12);
                        Console.WriteLine($"{currentPlayer.GetPlayerName(currentPlayer)}'s health has been reduced by {enemyDamageRoll} HP");
                        currentPlayer.TakePlayerHealth(currentPlayer, enemyDamageRoll);
                        Console.WriteLine($"The {currentPlayer.GetPlayerName(currentPlayer)} now has {currentPlayer.GetPlayerHealth(currentPlayer)} HP");

                    }

                } while ((currentEnemy.GetEnemyHealth(currentEnemy) > 0) && (currentPlayer.GetPlayerHealth(currentPlayer) > 0));

                Console.WriteLine("Fight over");
            }

            Fight();

            // refactoring the round method

            void Round()
            {
                Console.WriteLine($"{currentPlayer.GetPlayerName(currentPlayer)} has rolled {playerRoll}, the {currentEnemy.GetEnemyName(currentEnemy)} has rolled {enemyRoll}");
                Console.WriteLine($"{currentPlayer.GetPlayerName(currentPlayer)} wins the roll, the attack was successful!");
                Console.WriteLine("Hit a key to roll a D12 for damage amount");
                int playerDamageRoll = RollDice(12);
                Console.WriteLine($"{currentEnemy.GetEnemyName(currentEnemy)}'s health has been reduced by {playerDamageRoll} HP");
                currentEnemy.TakeEnemyHealth(currentEnemy, playerDamageRoll);
                Console.WriteLine($"The {currentEnemy.GetEnemyName(currentEnemy)} now has {currentEnemy.GetEnemyHealth(currentEnemy)} HP");
            }
        }






    }
}

