using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        // member methods (CAN DO)
    } // player  needs to purchase items from store mabye use inhertance of items to store and items to player
      // if forecast is sunny purchace more lemonade 
      // Else if forecast is rainy purchace less lemonade 
      // 
}
