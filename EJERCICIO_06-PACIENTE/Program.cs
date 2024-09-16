using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_06_PACIENTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente pa1 = new Paciente("Inés", "Méndez", 17, 1.75, 60);

            Listar("********* Datos sin modificar *********");
            ImprimirPaciente(pa1);

            // Actualizar datos
            pa1.Edad = 18;

            Listar("********* Datos modificados *********");
            ImprimirPaciente(pa1);

            Console.ReadKey();
        }

        public static void ImprimirPaciente(Paciente pa)
        {
            Listar("Nombre   : " + pa.Nombre);
            Listar("Apellido : " + pa.Apellido);
            Listar("Edad     : " + pa.Edad);
            Listar("Talla    : " + pa.Talla + " mts");
            Listar("Peso     : " + pa.Peso + " Kg");
            Listar("Estado   : " + pa.ObternerEstado() + "\n\n");
        }

        public static void Listar(string m)
        {
            Console.WriteLine(m);
        }
    }
}
