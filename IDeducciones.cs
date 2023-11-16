using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLogin
{
    public interface IDeducciones
    {
        public double salBasico { get; set; }
        public double innsLaboral { get; set; }
        public double IR { get; set; }
        public double CuotaSindical { get; set; }
        public double Anticipo { get; set; }
        public double Total { get; set; }
        public double calculandoInss();
        public double calculandoCuota();
        public double calculandoTotal(double iL, double A, double C, double i);


    }
}
