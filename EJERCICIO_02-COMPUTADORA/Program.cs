using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_02_COMPUTADORA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora comp1 = new Computadora(1001, "Lenovo", "Negro", 1000);

            Listar("********* Datos sin mofificar *********");
            ImprimirComputadora(comp1);

            // Actualizando los datos
            comp1.PrecioDolares *= 0.90;

            Listar("********* Datos mofificados *********");
            ImprimirComputadora(comp1);

            Console.ReadKey();
        }
        public static void ImprimirComputadora(Computadora comp)
        {
            Listar("Código            : " + comp.Codigo);
            Listar("Marca             : " + comp.Marca);
            Listar("Color             : " + comp.Color);
            Listar("Precio en Dólares : " + "$. " + comp.PrecioDolares.ToString("F2"));
            Listar("Precio en Soles   : " + "S/. " + comp.CalPrecioSoles().ToString("F2"));
            Listar("Precio en Euros   : " + "E. " + comp.CalPrecioEuros().ToString("F2") + "\n\n");

        }

        public static void Listar(string m)
        {
            Console.WriteLine(m);
        }

    }
}
