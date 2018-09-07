using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Observer_Station_Meteo
{
    public class DonneesMeteo : ISujet
    {
        private List<IObservateur> observateurs;
        private float temperature;
        private float humidite;
        private float pression;

        public DonneesMeteo()
        {
            observateurs = new List<IObservateur>();
        }


        public void EnregistrerObservateur(IObservateur o)
        {
            observateurs.Add(o);
        }

        public void SupprimerObservateur(IObservateur o)
        {
            observateurs.Remove(o);
        }

        public void NotifierObservateur()
        {
            foreach (IObservateur observateur in observateurs)
            {
                observateur.Actualiser(temperature, humidite, pression);
            }
        }

        public void ActualiserMesures()
        {
            NotifierObservateur();
        }

        public void setMesures (float temperature, float humidite, float pression)
        {
            this.temperature = temperature;
            this.humidite = humidite;
            this.pression = pression;
            ActualiserMesures();
        }
    }
}
