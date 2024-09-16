using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_09_PELOTA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota pel1 = new Pelota("ADIDAS", 400, 10, 30, 200);

            Listar("********* Datos sin modificar *********");
            ImprimirPelota(pel1);

            // Actualizando los datos
            pel1.Precio *= 0.75;
            pel1.DiametroCM += 1;

            Listar("********* Datos modificados *********");
            ImprimirPelota(pel1);

            Console.ReadKey();
        }

        public static void ImprimirPelota(Pelota pel)
        {
            Listar("Marca           : " + pel.Marca);
            Listar("Peso            : " + pel.PesoGramos + " gr");
            Listar("Presión         : " + pel.PresionLibras + " Lbs");
            Listar("Diametro        : " + pel.DiametroCM.ToString("F2") + " Cm");
            Listar("Precio          : " + "S/. " + pel.Precio.ToString("F2"));
            Listar("Radio           : " + pel.CalRadio().ToString("F2"));
            Listar("Volumen         : " + pel.CalVolumen().ToString("F2"));
            Listar("Descuento       : " + "S/. " + pel.CalDescuento().ToString("F2"));
            Listar("IMPORTE A PAGAR : " + "S/. " + pel.CalTotalPagar().ToString("F2") + "\n\n");
        }

        public static void Listar(string m)
        {
            Console.WriteLine(m);
        }
    }
}

