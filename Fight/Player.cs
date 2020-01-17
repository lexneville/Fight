using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    class Player
    {
        private string name { get; set; }
        private int health { get; set; }
        private int mana { get; set; }

        // private List<Items> Inventory = new List<Items>();
        public Player(string name)
        {
            this.name = name;
            this.health = 100;
            this.mana = 100;
        }
        public string GetName(Player player)
        {
            return this.name;
        }
        public int GetHealth(Player player)
        {
            return this.health;
        }
        public void TakeHealth(Player player, int healthChange)
        {
            
             this.health -= healthChange;
        }

        public void Heal(Player player, int healthChange)
        {
            this.health += healthChange;
        }
    }
}
