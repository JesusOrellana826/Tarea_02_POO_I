using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_04_OBRERO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero obr1 = new Obrero(4001, "Lucas Vargas", 50, 25);

            Listar("********* Datos sin modificar *********");
            ImprimirObrero(obr1);

            // Actualizando los datos
            obr1.HorasTrabajadas += 8;
            obr1.TarifaHora *= 0.985;

            Listar("********* Datos modificados *********");
            ImprimirObrero(obr1);

            Console.ReadKey();
        }

        public static void ImprimirObrero(Obrero ob)
        {
            Listar("Código           : " + ob.Codigo);
            Listar("Nombre           : " + ob.Nombre);
            Listar("Horas Trabajadas : " + ob.HorasTrabajadas);
            Listar("Tarifa por Hora  : " + "S/. " + ob.TarifaHora.ToString("F2"));
            Listar("Sueldo Bruto     : " + "S/. " + ob.CalSueldoBruto().ToString("F2"));
            Listar("Descuento AFP    : " + "S/. " + ob.CalAFP().ToString("F2"));
            Listar("Descuento EPS    : " + "S/. " + ob.CalEPS().ToString("F2"));
            Listar("SUELDO NETO      : " + "S/. " + ob.CalSueldoNeto().ToString("F2") + "\n\n");

        }

        public static void Listar(string m)
        {
            Console.WriteLine(m);
        }
    }
}
