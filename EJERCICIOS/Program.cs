using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular cel1 = new Celular(999666333, "Juan López", 1200, 0.11);

            Listar("********* Datos sin mofificar *********");
            ImprimirCelular(cel1);

            // Actualizando los datos
            cel1.SegundosConsumidos += 20;
            cel1.Precio *= 0.95;

            Listar("********* Datos modificados *********");
            ImprimirCelular(cel1);

            Console.ReadKey();
        }

        public static void ImprimirCelular(Celular c)
        {
            Listar("Número              : " + c.Numero);
            Listar("Usuario             : " + c.Usuario);
            Listar("Segundos Consumidos : " + c.SegundosConsumidos);
            Listar("Precio por segundo  : " + "S/. " + c.Precio.ToString("F2"));
            Listar("Costo por Consumo   : " + "S/. " + c.CalCostoConsumo().ToString("F2"));
            Listar("IGV                 : " + "S/. " + c.CalImpuestoIGV().ToString("F2"));
            Listar("Total a Pagar       : " + "S/. " + c.CalTotalPagar().ToString("F2") + "\n\n");

        }

        public static void Listar(string m)
        {
            Console.WriteLine(m);
        }

    }
}
