using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    class Enemy
    {
        private string enemyName { get; set; }
        private int enemyHealth { get; set; }
        private int enemyMana { get; set; }

        public Enemy(string enemyName, int enemyHealth, int enemyMana)
        {
            this.enemyName = enemyName;
            this.enemyHealth = enemyHealth;
            this.enemyMana = enemyMana;
        }

        public int GetEnemyHealth(Enemy enemy)
        {
            return this.enemyHealth;
        }

        public void takeEnemyHealth(Enemy enemy, int healthChange)
        {

            this.enemyHealth -= healthChange;
        }

    }
}
