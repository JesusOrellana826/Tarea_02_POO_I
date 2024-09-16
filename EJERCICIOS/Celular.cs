using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS
{
    public class Celular
    {
        // ATRIBUTOS
        private int numero;
        private string usuario;
        private int segundosConsumidos;
        private double precio;


        #region MÉTODOS GET Y SET
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public int SegundosConsumidos
        {
            get { return segundosConsumidos; }
            set { segundosConsumidos = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        #endregion

        // CONSTRUCTOR
        public Celular(int numero, string usuario, int segundosConsumidos, double precio) 
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segundosConsumidos = segundosConsumidos;
            this.precio = precio;
        }

        // MÉTODOS
        public double CalCostoConsumo()
        {
            return SegundosConsumidos * Precio;
        }

        public double CalImpuestoIGV()
        {
            return CalCostoConsumo() * 0.18;
        }

        public double CalTotalPagar()
        {
            return CalCostoConsumo() + CalImpuestoIGV();
        }
    }
}
