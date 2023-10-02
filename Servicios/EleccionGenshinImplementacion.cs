using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionGenshin.Servicios
{
    internal class EleccionGenshinImplementacion : EleccionGenshinInterfaz
    {
        /// <summary>
        /// Metodo que implementara por consola el menu
        /// 270923 - jzg
        /// </summary>
        public int implementacionMenu()
        {

            int eleccionSeleccionada;

            Console.WriteLine("###############################");
            Console.WriteLine("[¿A por que personaje tiraras?]");
            Console.WriteLine("0, cerrar app");
            Console.WriteLine("1, Neuvillete, ");
            Console.WriteLine("2, Hu Tao");
            Console.WriteLine("3, Furina");
            Console.WriteLine("###############################");
            Console.WriteLine("seleccione una opcion");

            eleccionSeleccionada=Console.ReadKey(true).KeyChar-('0');

            return eleccionSeleccionada;
        }

    }
}
