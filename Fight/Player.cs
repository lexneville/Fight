using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    class Player
    {
        private string playerName { get; set; }
        private int playerHealth { get; set; }
        private int playerMana { get; set; }

        // private List<Items> Inventory = new List<Items>();
        public Player(string PlayerName)
        {
            this.playerName = PlayerName;
            this.playerHealth = 100;
            this.playerMana = 100;
        }

        public int GetPlayerHealth(Player player)
        {
            return this.playerHealth;
        }
        public void TakePlayerHealth(Player player, int healthChange)
        {
            
             this.playerHealth -= healthChange;
        }

        public void HealPlayer(Player player, int healthChange)
        {
            this.playerHealth += healthChange;
        }
    }
}
