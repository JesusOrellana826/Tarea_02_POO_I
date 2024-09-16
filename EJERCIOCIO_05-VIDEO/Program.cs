using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCIOCIO_05_VIDEO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video vid1 = new Video(5001, "Video de Futbol", 10, 370);

            Listar("********* Datos sin modificar *********");
            ImprimirVideo(vid1);

            vid1.PrecioSoles += 5.50;

            Listar("********* Datos modificados *********");
            ImprimirVideo(vid1 );

            Console.ReadKey();
        }

        public static void ImprimirVideo(Video vid)
        {
            Listar("Código              : " + vid.Codigo);
            Listar("Nombre              : " + vid.Nombre);
            Listar("Minutos de duración : " + vid.Duracion);
            Listar("Precio en Soles     : " + "S/. " + vid.PrecioSoles.ToString("F2"));
            Listar("Precio en Dólares   : " + "S/. " + vid.CalPrecioDolares().ToString("F2") + "\n\n");

        }

        public static void Listar(string m)
        {
            Console.WriteLine(m);
        }
    }
}
