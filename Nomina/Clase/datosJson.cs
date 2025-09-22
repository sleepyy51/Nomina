using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Recursos
{
    public class datosJson
    {
        public double horasRegulares { get; set; }
        public double horasExtras { get; set; }
        public double dobleTurno { get; set; }

        public datosJson(double hr, double he, double dt)
        {
            horasRegulares = hr;
            horasExtras = he;
            dobleTurno = dt;
        }
    }
}
