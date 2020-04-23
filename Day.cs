using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        // member variables (HAS A)
        /* weather forcast*/
        
        public string Days;
        public List<Customer> customers;
        WeatherSystem dailyWeather;
        public bool dailySales;


        // constructor (SPAWNER)
        public Day()
        {
            dailyWeather = new WeatherSystem();
            dailySales = SalesBase();

        }




        // member methods (CAN DO)
        public void SalesBase()
        {



        }
        


        
       
        
         
    } 

}
