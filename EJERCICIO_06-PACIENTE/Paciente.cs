using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_06_PACIENTE
{
    public class Paciente
    {
        // ATRIBUTOS PRIVADOS
        private string nombre;
        private string apellido;
        private int edad;
        private double talla;
        private double peso;

        #region MÉTODOS GET Y SET
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public double  Talla
        {
            get { return talla; }
            set { talla = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        #endregion

        // CONSTRUCTOR
        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.talla = talla;
            this.peso = peso;
        }

        // MÉTODOS
        public string ObternerEstado()
        {
            if (Edad < 18) return "Menor de Edad";
            else return "Mayor de Edad";
        }
    }
}
