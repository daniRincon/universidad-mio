using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 PROBLEMA A RESOLVER

Con el objetivo de apoyar a los locales afectados por la pandemia se crea un bono de 5.000.000 para los locales que tengan más de 5 empleados
y tuvieron pérdidas superiores a 15 millones de pesos.

Crear un programa utilizando listas que permita censar los establecimientos comerciales de la ciudad de Quibdó,
de los cuales se debe permitir actualizar sus datos. De cada establecimiento se debe registrar como mínima los siguientes datos 
(nit, nombre, barrio, servicio que ofrece, jornada que trabaja (día - noche), cantidad de empleados actuales,
cantidad de empleados despedidos, perdidas en dinero por pandemia). 2p

• Listar los establecimientos nocturnos con pérdidas superiores a 50 millones. 1p
• Listar los establecimientos que trabajan por el día que despidieron empleados, el total de empleados despedidos y total de las perdidas. 1p
• Listar los establecimientos que recibieron el bono y el total entregado en bonos. 1p
 */


namespace portafolio2
{
    class Negocio
    {

        public int nit;
        public String nombre;
        public String barrio;
        public String servi;
        public String jornada;
        public int empleados;
        public int despidos;
        public long perdida;
        List<Negocio> Locales_ubi = new List<Negocio>();


        public int Nit { get => nit; set => nit = value; }

        public String Nombre { get => nombre; set => nombre = value; }

        public String Barrio { get => barrio; set => barrio = value; }

        public String Servi { get => servi; set => servi = value; }

        public String Jornada { get => jornada; set => jornada = value; }

        public int Empleados { get => empleados; set => empleados = value; }

        public int Despedidos { get => despidos; set => despidos = value; }

        public long Perdida { get => perdida; set => perdida = value; }


        public void Cargar()
        {
            Negocio cargar = new();
           
            Console.WriteLine("Ingrese el NIT del negocio");
            cargar.nit = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del negocio");
            cargar.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el barrio del negocio");
            cargar.barrio = Console.ReadLine();
            Console.WriteLine("Ingrese el Servicio que ofrece el negocio");
            cargar.servi = Console.ReadLine();
            Console.WriteLine("Ingrese la jornada de su negocio Día o Noche");
            cargar.jornada = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de empleados tiene su negocio");
            cargar.empleados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de empleados que ha despedido de su negocio");
            cargar.despidos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de perdida de dinero por la pandemia");
            cargar.perdida = long.Parse(Console.ReadLine());
            Locales_ubi.Add(cargar);
            Console.WriteLine("Negocio Agregado Exitosamente");

            Console.ReadKey();
        }


        public void Mostrar()
        {
            Console.WriteLine("Listado de negocios");
           
            foreach (Negocio p in Locales_ubi)
            {
                Console.WriteLine("************************");
                Console.WriteLine("NIT: " + p.Nit);
                Console.WriteLine("Nombre: " + p.Nombre);
                Console.WriteLine("Barrio: " + p.Barrio);
                Console.WriteLine("Servicio: " + p.Servi);
                Console.WriteLine("Jornada: " + p.Jornada);
                Console.WriteLine("Empleados que hay: " + p.Empleados);
                Console.WriteLine("Empleados despedidos: " + p.Despedidos);
                Console.WriteLine("Perdidad Monetarias: " + p.Perdida);
                Console.WriteLine("************************");
            }
        }


        public void Actualizar()
        {
           
            Console.Clear();
            bool buscar = false;
            Console.WriteLine("Ingrese el NIT del negocio que desea actualizar los datos");
            int Buscar_NIT = int.Parse(Console.ReadLine());

            foreach (Negocio p in Locales_ubi)
            {

                if (Buscar_NIT == p.Nit)
                {
                    Console.WriteLine("************************");
                    Console.WriteLine("NIT: " + p.Nit);
                    Console.WriteLine("Nombre: " + p.Nombre);
                    Console.WriteLine("Barrio: " + p.Barrio);
                    Console.WriteLine("Servicio: " + p.Servi);
                    Console.WriteLine("Jornada: " + p.Jornada);
                    Console.WriteLine("Empleados que hay: " + p.Empleados);
                    Console.WriteLine("Empleados despedidos: " + p.Despedidos);
                    Console.WriteLine("Perdidad Monetarias: " + p.Perdida);
                    Console.WriteLine("************************");


                    Console.WriteLine("Ingrese el nombre del negocio");
                    p.nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo barrio del negocio");
                    p.barrio = Console.ReadLine();                   
                    Console.WriteLine("Ingrese la nueva jornada de su negocio Día o Noche");
                    p.jornada = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo numero de empleados tiene su negocio");
                    p.empleados = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nuevo numero de empleados que ha despedido de su negocio");
                    p.despidos = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nuevo valor de perdida de dinero por pandemia");
                    p.perdida = long.Parse(Console.ReadLine());                   
                    Console.WriteLine("Negocio Actualizado Exitosamente");
                    buscar = true;
                    Console.ReadKey();

                }   
            }

            if(buscar == false)
            {
                Console.WriteLine("El negocio con numero de NIT: " + Buscar_NIT + " no esta en la lista");
            }
            Console.ReadKey();
        }

        

        public void Bonos()
        {
            
            int cont = 0;
             long total_bonos;
            
            foreach (Negocio p in Locales_ubi)
            {

                if (p.empleados >= 5 && p.perdida >= 15000000)
                {
                    Console.WriteLine("FELICITACIONES SE LE HA DONADO UN BONO DE 5.000.000 DE PESOS");
                    Console.WriteLine("************************");
                    Console.WriteLine("NIT: " + p.Nit);
                    Console.WriteLine("Nombre: " + p.Nombre);
                    Console.WriteLine("Barrio: " + p.Barrio);
                    Console.WriteLine("Servicio: " + p.Servi);
                    Console.WriteLine("Jornada: " + p.Jornada);
                    Console.WriteLine("Empleados que hay: " + p.Empleados);
                    Console.WriteLine("Empleados despedidos: " + p.Despedidos);
                    Console.WriteLine("Perdidad Monetarias: " + p.Perdida);
                    Console.WriteLine("************************");
                    cont++;
                    Console.ReadKey();

                }
            }
            total_bonos = cont * 5000000;

            Console.WriteLine("El total de bonos entrados son: " + total_bonos + " Pesos");

        }


        public void Noche()
        {
            
            foreach (Negocio p in Locales_ubi)
            {

                if (p.jornada == "noche" && p.perdida >= 50000000)
                {

                    Console.WriteLine("************************");
                    Console.WriteLine("NIT: " + p.Nit);
                    Console.WriteLine("Nombre: " + p.Nombre);
                    Console.WriteLine("Barrio: " + p.Barrio);
                    Console.WriteLine("Servicio: " + p.Servi);
                    Console.WriteLine("Jornada: " + p.Jornada);
                    Console.WriteLine("Empleados que hay: " + p.Empleados);
                    Console.WriteLine("Empleados despedidos: " + p.Despedidos);
                    Console.WriteLine("Perdidad Monetarias: " + p.Perdida);
                    Console.WriteLine("************************");

                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("No hay ningun negocio asociado");
                }
            }
        }


        public void Dia()
        {
            
            int  totaldes=0;
            long totalper=0;
            foreach (Negocio p in Locales_ubi)
            {

                if (p.jornada == "dia" && p.despidos >=1)
                {

                    Console.WriteLine("************************");
                    Console.WriteLine("NIT: " + p.Nit);
                    Console.WriteLine("Nombre: " + p.Nombre);
                    Console.WriteLine("Barrio: " + p.Barrio);
                    Console.WriteLine("Servicio: " + p.Servi);
                    Console.WriteLine("Jornada: " + p.Jornada);
                    Console.WriteLine("Empleados que hay: " + p.Empleados);
                    Console.WriteLine("Empleados despedidos: " + p.Despedidos);
                    Console.WriteLine("Perdidad Monetarias: " + p.Perdida);
                    Console.WriteLine("************************");

                    Console.ReadKey();

                    totaldes +=  p.despidos;
                    totalper += p.perdida;
                }
            }

            Console.WriteLine("El total de personas despedidas fueron: " + totaldes + " personas");           
            Console.WriteLine("El total de Dinero Perdido por la pandemia es de: " + totalper + " pesos");

        }





    }
}
