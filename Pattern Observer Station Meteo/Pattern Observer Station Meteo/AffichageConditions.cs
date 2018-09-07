using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Observer_Station_Meteo
{
    class AffichageConditions : IObservateur, IAffichage
    {
        private float temperature;
        private float humidite;
        private ISujet donneesMeteo;

        public AffichageConditions (ISujet donneesMeteo)
        {
            this.donneesMeteo = donneesMeteo;
            donneesMeteo.EnregistrerObservateur(this);
        }

        public void Actualiser(float temperature, float humidite, float pression)
        {
            this.temperature = temperature;
            this.humidite = humidite;
            Afficher();
        }

        public void Afficher()
        {
            Console.WriteLine($"Conditions actuelles : {temperature} °C et {humidite} % d'humidité");
        }
    }
}
