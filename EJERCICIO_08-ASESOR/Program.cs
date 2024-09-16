using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_08_ASESOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor as1 = new Asesor(7001, "Julián García", 50, 50);

            Listar("********* Datos sin modificar *********");
            ImprimirAsesor(as1);

            // Actualizando los datos
            as1.HorasTrabajadas += 10;
            as1.TarifaHora *= 0.85;

            Listar("********* Datos modificados *********");
            ImprimirAsesor(as1);

            Console.ReadKey();
        }

        public static void ImprimirAsesor(Asesor ase)
        {
            Listar("Código           : " + ase.Codigo);
            Listar("Nombre           : " + ase.Nombre);
            Listar("Horas Trabajadas : " + ase.HorasTrabajadas);
            Listar("Tarifa por Hora  : " + "S/. " + ase.TarifaHora.ToString("F2"));
            Listar("Sueldo Bruto     : " + "S/. " + ase.CalSueldoBruto().ToString("F2"));
            Listar("Descuento        : " + "S/. " + ase.CalDescuento().ToString("F2"));
            Listar("SUELDO NETO      : " + "S/. " + ase.CalSueldoNeto().ToString("F2") + "\n\n");
        }

        public static void Listar(string m)
        {
            Console.WriteLine(m);
        }
    }
}
