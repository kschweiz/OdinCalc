using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinCalc
{
    class Rechnung
    {
        public double dichte, volumen, masse;
        public Rechnung(double dichte, double volumen, double masse)
        {
            this.dichte = dichte;
            this.volumen = volumen;
            this.masse = masse;
        }
        
        public double GetDichte()
        {
            return masse / volumen;
        }

        public double GetVolumen()
        {
            return masse / dichte;
        }

        public double GetMasse()
        {
            return dichte * volumen;
        }
    }
}
