using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3___Guía4_MM200149
{
    public abstract class Figura
    {
        private double area;
        public Figura(double A)
        {
            area = A;
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public virtual void CalcularArea(Label LR)
        {

        }

    }

    public class Cuadrado: Figura
    {

        private double lado;
        public Cuadrado(double A, double L):base (A)
        {
            lado = L;
        }

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }


        public override void CalcularArea(Label LR)
        {
            Area = (Lado * Lado);
            LR.Text = "Area: " + Area;

        }

    }





}
