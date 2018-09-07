using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Observer_Station_Meteo
{
    class Program
    {
        static void Main(string[] args)
        {
            DonneesMeteo donneesMeteo = new DonneesMeteo();

            AffichageConditions affichageCond = new AffichageConditions(donneesMeteo);

            donneesMeteo.setMesures(26, 65, 1020);
            donneesMeteo.setMesures(28, 70, 1012);
            donneesMeteo.setMesures(22, 90, 1012);
        }
    }
}
