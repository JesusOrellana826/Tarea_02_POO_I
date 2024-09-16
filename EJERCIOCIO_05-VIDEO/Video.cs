using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCIOCIO_05_VIDEO
{
    public class Video
    {
        private int codigo;
        private string nombre;
        private double duracion;
        private double precioSoles;
        private const double TipoCambio = 3.70;

        #region MÉTODOS GET Y SET
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        public double PrecioSoles
        {
            get { return precioSoles; }
            set { precioSoles = value; }
        }
        #endregion

        // CONSTRUCTOR
        public Video(int codigo, string nombre, double duracion, double precioSoles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.duracion = duracion;
            this.precioSoles = precioSoles;
        }

        // MÉTODOS
        public double CalPrecioDolares()
        { 
            return PrecioSoles / TipoCambio;
        }
    }
}
