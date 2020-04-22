using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class WeatherSystem
    {
        // member variables (HAS A)
        private List<string> forecastOptions;
        //public List<int> tempature;
        public string dailyForecast;
        public int dailyTemperature;
        public Random rand;
       



        // constructor (SPAWNER)
        public WeatherSystem()
        {
            rand = new Random();
            forecastOptions = new List<string>() { "sunny", "rainy", "overcast" };
            //tempature = new List<int>() { 40, 80 };
            dailyForecast = DetermineCondition();
            dailyTemperature = DetermineTemperature();
        }




        // member methods (CAN DO)
        public string DetermineCondition()
        {
            int randomNumber = rand.Next(forecastOptions.Count);
            return forecastOptions[randomNumber];
        }

        public int DetermineTemperature()
        {
            int randomTemp = rand.Next(40, 81);
            return randomTemp;
        }

    }
}

    
      






    

   

        


