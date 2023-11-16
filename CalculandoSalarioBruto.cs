using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLogin
{
    public class CalculandoSalarioBruto
    {
        public double horasExtras { get; set; }
        public double Antiguedad { get; set; }
        public double salarioBasico { get; set;}
        public double salarioBruto { get; set;}
        public int h { get; set;}
        public double A { get; set; }
        
        public CalculandoSalarioBruto(double salario, int antiguedad, int horas, double total)
        {
            h = horas;
            A = antiguedad;
            salarioBasico = salario;
            salarioBruto = total;
        }

        public double CalculandoHoras()
        {
            horasExtras = salarioBasico / 30;
            horasExtras=horasExtras / 8;
            horasExtras=horasExtras*h;
            horasExtras = horasExtras * 2;
            return Math.Round(horasExtras,4);
        }
        public double CalculandoAntiguedad()
        {
            A = A/100;
            Antiguedad=salarioBasico*A;
            return Antiguedad;
        }
        public double CalculandoSalarioBrut()
        {
            salarioBruto=salarioBasico+Antiguedad+horasExtras;
            return salarioBruto;
        }
    }
}
