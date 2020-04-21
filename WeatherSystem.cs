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
        public List<int> tempature;
        public string dailyForecast;
        public int dailyTemperature;
        public string weather;
    }


    // constructor (SPAWNER)
    public WeatherSystem()

    {
        forecastOptions = new List<string>() { "sunny", "rainy", "overcast" };
        tempature = new List<int>() { 40, 80 };
        weather = DetermineWeather();

    }




    // member methods (CAN DO)
    public string DetermineWeather()
    {
        Random rand = new Random();
        int randomNumber = rand.Next(weather.count);
        return weather[randomNumber];
    } 

}

    
      






    

   

        


