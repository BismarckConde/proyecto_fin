using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLogin
{
    public interface ICalculandoOtros
    {
        public double SalBruto { get; set; }
        public double InssPatronal { get; set;}
        public double Inatec { get; set;}
        public double Vacacciones { get; set;}

        public double CalculandoInatec();
        public double CalculandoVacacciones(string a);
        public double CalculandoInssPatronal();

    }
}
