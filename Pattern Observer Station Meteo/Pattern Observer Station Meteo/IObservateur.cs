﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Observer_Station_Meteo
{
    public interface IObservateur
    {
        void Actualiser(float temp, float humidite, float pression);
    }
}
