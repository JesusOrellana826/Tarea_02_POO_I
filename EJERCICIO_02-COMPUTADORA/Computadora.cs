using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_02_COMPUTADORA
{
	internal class Computadora
	{
		// ATRIBUTOS PRIVADOS
		private int codigo;
		private string marca;
		private string color;
		private double precioDolares;

        #region MÉTODOS GET Y SET
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double PrecioDolares
        {
            get { return precioDolares; }
            set { precioDolares = value; }
        }
        #endregion


        // CONSTRUCTOR
        public Computadora(int codigo, string marca, string color, double precioDolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precioDolares = precioDolares;
        }

		public double CalPrecioSoles()
		{
			return PrecioDolares * 3.35;
		}

		public double CalPrecioEuros()
		{
			return PrecioDolares / 1.20;
		}
    }
}
