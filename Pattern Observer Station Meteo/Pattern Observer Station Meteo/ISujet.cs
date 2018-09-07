using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Observer_Station_Meteo
{
    public interface ISujet
    {
        void EnregistrerObservateur(IObservateur o);
        void SupprimerObservateur(IObservateur o);
        void NotifierObservateur();
        
    }
}
