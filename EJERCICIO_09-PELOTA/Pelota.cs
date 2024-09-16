using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_09_PELOTA
{
    public class Pelota
    {
        // ATRIBUTOS PRIVADOS
        private string marca;
        private double pesoGramos;
        private double presionLibras;
        private double diametroCM;
        private double precio;

        #region MÉTODOS GET Y SET
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public double PesoGramos
        {
            get { return pesoGramos; }
            set { pesoGramos = value; }
        }
        public double PresionLibras
        {
            get { return presionLibras; }
            set { presionLibras = value; }
        }
        public double DiametroCM
        {
            get { return diametroCM; }
            set { diametroCM = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        #endregion

        // CONSTRUCTOR
        public Pelota(string marca, double pesoGramos, double presionLibras, double diametroCM, double precio)
        {
            this.marca = marca;
            this.pesoGramos = pesoGramos;
            this.presionLibras = presionLibras;
            this.diametroCM = diametroCM;
            this.precio = precio;
        }

        // MÉTODOS
        public double CalRadio()
        {
            return DiametroCM / 2;
        }

        public double CalVolumen()
        {
            return (4 * 3.1416 * CalRadio() * CalRadio() * CalRadio()) / 3;
        }

        public double CalDescuento()
        {
            return Precio * 0.10;
        }

        public double CalTotalPagar()
        {
            return Precio - CalDescuento();
        }
    }
}
