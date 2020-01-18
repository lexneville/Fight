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

            Player currentPlayer = Hero;
            Enemy currentEnemy = goblin;

            Random rand = new Random();

            int playerRoll, enemyRoll;
            string playerName = currentPlayer.GetName(currentPlayer);
            string enemyName = currentEnemy.GetName(currentEnemy);

            int playerHealth()
            {
               return currentPlayer.GetHealth(currentPlayer);
            };

            int enemyHealth()
            {
                return currentEnemy.GetHealth(currentEnemy);
            };

            int RollDice(int maxValue) 
            {
                return rand.Next(1, maxValue);
            };

            void Potion()
            {
                currentPlayer.Heal(currentPlayer, 50);
            }


            void Fight()
            {
                Console.WriteLine($"You encounter a {enemyName}");
                Console.WriteLine("Potion");
                Potion();

/*trade blows*/do 
                {
                    Console.WriteLine("Hit a key to roll the dice!");
                    Console.WriteLine("If you roll higher than the enemy rolls, your strike is successful");
                    Console.ReadKey();
                    Console.WriteLine();
                    playerRoll = RollDice(6);
                    enemyRoll = RollDice(6);

                    // string playerChoices = "";
                    void RollResult()
                    {
                        Console.WriteLine($"{playerName} has rolled {playerRoll}, the {enemyName} has rolled {enemyRoll}"); 
                    };

                    void HealthDisplay()
                    {
                        Console.WriteLine($"The {playerName} now has {playerHealth()} HP");
                        Console.WriteLine($"The {enemyName} now has {enemyHealth()} HP");
                    };
                    


                    if (playerRoll > enemyRoll)
                    {


                        RollResult();


                        Console.WriteLine($"{playerName} wins the roll, your attack was successful!");
                        Console.WriteLine("Hit a key to roll a D20 for damage amount");
                        int playerDamageRoll = RollDice(20);

                        Console.WriteLine($"{enemyName}'s health has been reduced by {playerDamageRoll} HP");
                        currentEnemy.TakeHealth(currentEnemy, playerDamageRoll);
                        HealthDisplay();

                    }
                    else if (playerRoll < enemyRoll)
                    {

                        RollResult();

                        
                        Console.WriteLine($"{enemyName} wins the roll, your attack was blocked and the {enemyName} strikes back!");
                        Console.WriteLine($"The {enemyName} rolls a D12 for damage");
                        int enemyDamageRoll = RollDice(12);
                        Console.WriteLine($"{playerName}'s health has been reduced by {enemyDamageRoll} HP");
                        currentPlayer.TakeHealth(currentPlayer, enemyDamageRoll);
                        HealthDisplay();
                    }
                    else
                    {

                    }

                } while (enemyHealth() > 0 && playerHealth() > 0);

                Console.WriteLine("Fight over");
            };

            Fight();

        }

    }
}

