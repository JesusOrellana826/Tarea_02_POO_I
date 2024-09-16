using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_03_EDIFICIO
{
    public class Edificio
    {
		private int codigo;
        private int numDeptos;
        private int cantPisos;
        private double precioDeptoDolares;

        #region MÉTODOS GET Y SET
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int NumDeptos
        {
            get { return numDeptos; }
            set { numDeptos = value; }
        }
        public int CantPisos
        {
            get { return cantPisos; }
            set { cantPisos = value; }
        }
        public double PrecioDeptoDolares
        {
            get { return precioDeptoDolares; }
            set { precioDeptoDolares = value; }
        }
        #endregion

        // CONSTRUCTOR
        public Edificio(int codigo, int numDeptos, int cantPisos, double precioDeptoDolares)
        {
            this.codigo = codigo;
            this.numDeptos = numDeptos;
            this.cantPisos = cantPisos;
            this.precioDeptoDolares = precioDeptoDolares;
        }
        
        public double CalPrecioEdificioDolares()
        {
            return numDeptos * precioDeptoDolares;
        }
    }
}
