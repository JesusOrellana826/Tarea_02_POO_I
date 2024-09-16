using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_07_EMPLEADO
{
    public class Empleado
    {
        // ATRIBUTOS PRIVADOS
        private int codigo;
        private string nombre;
        private int telefono;
        private double sueldoSoles;

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
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public double SueldoSoles
        {
            get { return sueldoSoles; }
            set { sueldoSoles = value; }
        }
        #endregion

        // CONSTRUCTOR
        public Empleado(int codigo, string nombre, int telefono, double sueldoSoles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.telefono = telefono;
            this.sueldoSoles = sueldoSoles;
        }

        // MÉTODOS
        public string CalCategoriaSueldo()
        {
            if (SueldoSoles > 3500) return "Sueldo MAYOR a 3,500 soles";
            else if (SueldoSoles == 3500) return "Sueldo IGUAL a 3,500 soles";
            else return "Sueldo MENOR a 3,500 soles";
        }
    }
}
