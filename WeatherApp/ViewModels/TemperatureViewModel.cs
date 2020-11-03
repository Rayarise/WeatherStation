using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
        /// 
        public static double CelsiusInFahrenheit(double c) {

            return Math.Round(((c * 9) / 5) + 32, 1);  
            
        }
    }
}
