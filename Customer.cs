using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer 
    {

        // member variables (HAS A)
        private List<string> names;
        public string name;
        public int daiyBuyingDrinks;
        public Random rand;
        public int demand;

        // constructor (SPAWNER)
        public Customer()
        {
            names = new List<string>() { "happy", "chubbs", "bob", "shooter" };
            daiyBuyingDrinks = PurchaseCups();
            demand = new Demand();

        }




        // member methods (CAN DO)
        public void PurchaseCups()
        {
            int randomNumber = rand.Next(names.Count);
            name = names[randomNumber];
             

            
        }
        public int Demand()
        {
            

        }

    }
 }   



    
