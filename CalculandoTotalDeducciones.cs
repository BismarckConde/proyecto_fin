using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLogin
{
    public class CalculandoTotalDeducciones : IDeducciones
    {
        public double innsLaboral { get ; set ; }
        public double IR { get ; set  ; }
        public double CuotaSindical { get; set ; }
        public double Anticipo { get; set ; }
        public double Total { get ; set ; }
        public double salBasico { get ; set ; }
        public double salBruto { get; set; }
        public double Cuo { get; set; }
        public double ir { get; set; }
        public CalculandoTotalDeducciones(double sal,double cuo,double anticipo,double salBru)
        {
            Cuo = cuo;
            Anticipo = anticipo;
            salBasico = sal;
            salBruto = salBru;
        }

        public double calculandoCuota()
        {
            Cuo = Cuo/100;
            CuotaSindical = Cuo * salBasico;
            return CuotaSindical;
        }

        public double calculandoInss()
        {
            innsLaboral = salBruto * 0.07;
            return Math.Round(innsLaboral,4);
        }
        public double calculandoIr(string a)
        {
            if (a.Equals("Anual"))
            {
                ir = salBruto - Math.Round(innsLaboral, 4);
                ir = ir * 12;
                if (ir <= 100000)
                {
                    ir = 0;
                    IR = ir;

                }
                else
                {
                    if (ir <= 200000)
                    {
                        ir = ir - 100000;
                        ir = ir * 0.15;
                        ir = ir / 12;
                        IR = ir;


                    }
                    else
                    {
                        if (ir <= 350000)
                        {
                            ir = ir - 200000;
                            ir = ir * 0.20;
                            ir = ir + 15000;
                            ir = ir / 12;
                            IR = ir;

                        }
                        else
                        {
                            if (ir <= 500000)
                            {
                                ir = ir - 350000;
                                ir = ir * 0.25;
                                ir = ir + 45000;
                                ir = ir / 12;
                                IR = ir;

                            }
                            else
                            {
                                if (ir > 500000)
                                {
                                    ir = ir - 500000;
                                    ir = ir * 0.30;
                                    ir = ir + 82500;
                                    ir = ir / 12;
                                    IR = ir;

                                }
                            }
                        }
                    }

                }
            }
            else
            {
                if (a.Equals("Mensual"))
                {
                    ir = salBruto - Math.Round(innsLaboral, 4);
                    ir = ir * 12;
                    if (ir <= 100000)
                    {
                        ir = 0;
                        IR = ir;

                    }
                    else
                    {
                        if (ir <= 200000)
                        {
                            ir = ir - 100000;
                            ir = ir * 0.15;
                            ir = ir / 12;
                            IR = ir;


                        }
                        else
                        {
                            if (ir <= 350000)
                            {
                                ir = ir - 200000;
                                ir = ir * 0.20;
                                ir = ir + 15000;
                                ir = ir / 12;
                                IR = ir;

                            }
                            else
                            {
                                if (ir <= 500000)
                                {
                                    ir = ir - 350000;
                                    ir = ir * 0.25;
                                    ir = ir + 45000;
                                    ir = ir / 12;
                                    IR = ir;

                                }
                                else
                                {
                                    if (ir > 500000)
                                    {
                                        ir = ir - 500000;
                                        ir = ir * 0.30;
                                        ir = ir + 82500;
                                        ir = ir / 12;
                                        IR = ir;

                                    }
                                }
                            }
                    }   }
                }
                else 
                {
                    if (a.Equals("Semanal"))
                    {
                        ir = salBruto - Math.Round(innsLaboral, 4);
                        ir = ir * 4;
                        if (ir <= 8333.33)
                        {
                            ir = 0;
                            IR = ir;

                        }
                        else
                        {
                            if (ir <= 16666.66)
                            {
                                ir = ir - 8333.33;
                                ir = ir * 0.15;
                                ir = ir / 4;
                                IR = ir;


                            }
                            else
                            {
                                if (ir <= 29166.66)
                                {
                                    ir = ir - 16666.66;
                                    ir = ir * 0.20;
                                    ir = ir + 1250;
                                    ir = ir / 4;
                                    IR = ir;

                                }
                                else
                                {
                                    if (ir <= 41666.66)
                                    {
                                        ir = ir - 29166.66;
                                        ir = ir * 0.25;
                                        ir = ir + 3750;
                                        ir = ir / 4;
                                        IR = ir;

                                    }
                                    else
                                    {
                                        if (ir > 41666.66)
                                        {
                                            ir = ir - 41666.66;
                                            ir = ir * 0.30;
                                            ir = ir + 6875;
                                            ir = ir / 4;
                                            IR = ir;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        IR = 0;
                    }
                }  
            }
            return Math.Round(IR,4);

        }


        public double calculandoTotal(double iL,double A,double C,double i)
        {
            Total=iL+A+C+i;
            return Total;
        }

        
    }
}
