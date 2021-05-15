using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portafolio2
{
    class Menu
    {
        private int opc;
        private Negocio locales = new  Negocio();

       


        public void menun()
        {
            do
            {
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("BIENVENIDO AL CENSO NACIONAL DE NEGOCIOS PARA AYUDA FINANCIERA");
                    Console.WriteLine("");
                    Console.WriteLine("MENU DE OPCIONES");
                    Console.WriteLine("1 -> Agregar Negocio");
                    Console.WriteLine("2 -> Listar Los Negocios");
                    Console.WriteLine("3 -> Modificar Negocios");
                    Console.WriteLine("4 -> Lista de Negocios nocturnos con perdidas superior a 50 millones");
                    Console.WriteLine("5 -> Lista de Negocias Diurnos eon empleados despedidos + total de empleados despedidos y total de perdida monetaria");
                    Console.WriteLine("6 -> Lista de Negocios que recibieron bono, y total de bonos entregados");
                    Console.WriteLine("0 -> Salir");
                    Console.WriteLine("");
                    Console.Write("Elija una opción: ");
                    opc = int.Parse(Console.ReadLine());

                    if (opc < 0 || opc > 6)
                    {
                        Console.WriteLine("Ingrese una opcion valida");
                        Console.ReadKey();
                    }
                } while (opc < 0 || opc > 6);

                switch (opc)
                {
                    case 1:
                        locales.Cargar();
                        Console.ReadKey();
                        break;


                    case 2:
                        locales.Mostrar();
                        Console.ReadKey();
                        break;


                    case 3:
                        locales.Actualizar();
                        Console.ReadKey();
                        break;


                    case 4:
                        locales.Noche();
                        Console.ReadKey();
                        break;

                    case 5:
                        locales.Dia();
                        Console.ReadKey();
                        break;

                    case 6:
                        locales.Bonos();
                         break;

                }




            } while (opc != 0);
        }
    }
}
