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

        public virtual void CalcularArea(TextBox TB)
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


        public override void CalcularArea( TextBox TB)
        {
            Area = (Lado * Lado);
            TB.Text = "" + Area;
        }

    }

    public class Circulo:Figura
    {
        private double radio;
        public Circulo(double A, double R):base(A)
        {
            radio = R;
        }

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public override void CalcularArea(TextBox TB)
        {
            Area = (Math.PI * Math.Pow(Radio, 2));
            TB.Text = "" + Area;
        }

    }

    public class Rombo : Figura
    {
        private double diagonalmayor;
        private double diagonalmenor;
        public Rombo(double A, double DMa, double DMe):base(A)
        {
            diagonalmayor = DMa;
            diagonalmenor = DMe;
        }

        public double DiagonalMayor
        {
            get { return diagonalmayor; }
            set { diagonalmayor = value; }
        }

        public double DiagonalMenor
        {
            get { return diagonalmenor; }
            set { diagonalmenor = value; }
        }


        public override void CalcularArea(TextBox TB)
        {
            Area = (DiagonalMayor * DiagonalMenor) / 2;
            TB.Text = "" + Area;
        }


    }



}
