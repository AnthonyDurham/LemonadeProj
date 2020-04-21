using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player:Store
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        
        // constructor (SPAWNER)
        public Player()
        {
            name = "server";
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();


        }

        // member methods (CAN DO)

        // I want to be able to go to the store to purchase items(lemons, sugar, ice, and cups) so that I can make lemonade to sell. 
    } 
}
