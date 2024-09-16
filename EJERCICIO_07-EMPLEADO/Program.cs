using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_07_EMPLEADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado emp1 = new Empleado(6001, "Roberto Cabrera", 999888777, 3300);

            Listar("********* Datos sin modificar *********");
            ImprimirEmpleado(emp1);

            // Actualizando los datos
            emp1.Telefono = 922555000;
            emp1.SueldoSoles += 200;

            Listar("********* Datos modificados *********");
            ImprimirEmpleado(emp1);

            Console.ReadKey();
        }

        public static void ImprimirEmpleado(Empleado emp)
        {
            Listar("Código            : " + emp.Codigo);
            Listar("Nombre            : " + emp.Nombre);
            Listar("Teléfono          : " + emp.Telefono);
            Listar("Sueldo en Soles   : " + "S/. " + emp.SueldoSoles.ToString("F2"));
            Listar("Precio en Dólares : " + "S/. " + emp.CalCategoriaSueldo() + "\n\n");
        }

        public static void Listar(string m)
        {
            Console.WriteLine(m);
        }
    }
}
