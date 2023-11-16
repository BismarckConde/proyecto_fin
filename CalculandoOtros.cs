using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLogin
{
    public class CalculandoOtros : ICalculandoOtros
    {
        public double InssPatronal { get ; set ; }
        public double Inatec { get ; set; }
        public double Vacacciones { get; set ; }
        public double SalBruto { get; set; }
        public CalculandoOtros(double salBruto)
        {
            SalBruto = salBruto;

        }

        public double CalculandoInatec()
        {
            Inatec = SalBruto*0.02;
            return Inatec;
        }

        public double CalculandoInssPatronal()
        {
            InssPatronal=SalBruto*0.225;
            return Math.Round(InssPatronal, 4);
        }

        public double CalculandoVacacciones(string a)
        {
            if (a.Equals("Semanal"))
            {
                Vacacciones = SalBruto / 30;
                Vacacciones = Vacacciones * 0.625;
            }
            else
            {
                Vacacciones = SalBruto / 30;
                Vacacciones = Vacacciones * 2.5;
            }
            return Math.Round(Vacacciones, 4);
        }
    }
}
