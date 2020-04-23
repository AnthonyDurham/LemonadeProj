using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        // member variables (HAS A)
        private Player player;
        Store store;
        private List<Day> days;
        private int currentDay;
        public int demand;
        private WeatherSystem weatherSystem;

        // constructor (SPAWNER)
        public Game()
        {
            player = new Player();
            store = new Store();
            demand = new
           

        }


        // member methods (CAN DO)

        public void PurchaceItems()
        {
            store.SellLemons(player);
            store.SellCups(player);
            store.SellIceCubes(player);
            store.SellSugarCubes(player);

        }

        public int Demand()
        {
            if (Customer.forcastOptions & dailyTemperature >= "sunny" + 80) 
            {
                Customer.purchaceCups[i]++;
            }
            else (Customer.forcastOptions & dailyTemperatur <="rainy"+ 40)
                    {
                    Customer.purchaceCups[i]--;

                    }



        }


    }



}


