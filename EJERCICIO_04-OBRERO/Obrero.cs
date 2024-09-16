using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_04_OBRERO
{
    public class Obrero
    {
		private int codigo;
        private string nombre;
        private int horasTrabajadas;
        private double tarifaHora;

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
        public int HorasTrabajadas
        {
            get { return horasTrabajadas; }
            set { horasTrabajadas = value; }
        }
        public double TarifaHora
        {
            get { return tarifaHora; }
            set { tarifaHora = value; }
        }
        #endregion

        // CONSTRUCTOR
        public Obrero(int codigo, string nombre, int horasTrabajadas, double tarifaHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaHora = tarifaHora;
        }

        // MÉTODOS
        public double CalSueldoBruto()
        {
            return HorasTrabajadas * TarifaHora;
        }

        public double CalAFP()
        {
            return CalSueldoBruto() * 0.10;
        }

        public double CalEPS()
        {
            return CalSueldoBruto() * 0.05;
        }

        public double CalSueldoNeto()
        {
            return CalSueldoBruto() - CalAFP() - CalEPS();
        }
    }
}
