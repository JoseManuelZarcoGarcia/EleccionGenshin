using EleccionGenshin.Servicios;

namespace EleccionGenshin.Controladores
{
    /// <summary>
    /// Metodo principal desde el cual se iniciara la app
    /// 270923 - jzg
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo de entrada a la app
        /// 270923 - jzg
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {

            EleccionGenshinInterfaz eg = new EleccionGenshinImplementacion();
            eg.implementacionMenu();

            bool cerrarMenu = false;
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = eg.implementacionMenu();
                Console.WriteLine(opcionSeleccionada);
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[info] - se ejecuta el caso 0");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[info] - Bien, ejejistes a Neuvillete");
                        break;

                    case 2:
                        Console.WriteLine("[info] - Bien, ejejistes a Hu Tao");
                        break;

                    case 3:
                        Console.WriteLine("[info] - Bien, ejejistes a Furina");
                        break;


                    default:
                        Console.WriteLine("[info] - la opcion deseada no existe.");
                        break;
                }

            }

        }

    }

}
