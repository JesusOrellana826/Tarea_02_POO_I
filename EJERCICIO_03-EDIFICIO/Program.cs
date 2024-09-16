using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_03_EDIFICIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio edif1 = new Edificio(3001, 16, 8, 100000);

            Listar("********* Datos sin mofificar *********");
            ImprimirEdificio(edif1);

            edif1.PrecioDeptoDolares *= 1.20;

            Listar("********* Datos modificados *********");
            ImprimirEdificio(edif1);

            Console.ReadKey();
        }

        public static void ImprimirEdificio(Edificio e)
        {
            Listar("Código                    : " + e.Codigo);
            Listar("Cantidad de Departamentos : " + e.NumDeptos);
            Listar("Cantidad de Pisos         : " + e.CantPisos);
            Listar("Precio por Departamento   : " + "$. " + e.PrecioDeptoDolares.ToString("F2"));
            Listar("PRECIO TOTAL DEL EDIFICIO : " + "E. " + e.CalPrecioEdificioDolares().ToString("F2") + "\n\n");

        }

        public static void Listar(string m)
        {
            Console.WriteLine(m);
        }
    }
}
