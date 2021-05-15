using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_listas
{
    public class Clsclientes
    {
        public int cedula;
        public string nombre;
        public string apellido;
        public string sexo;
        public int edad;
        public string direccion;
        public string tipo_c;
        
        List<Clsclientes> lista_clientes = new List<Clsclientes>();

        /*public Clsclientes (int cedula, string nombre, string apellido, string sexo, int edad, string direccion, string tipo_c)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.direccion = direccion;
            this.tipo_c = tipo_c;
        }*/
        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Tipo_c { get => tipo_c; set => tipo_c = value; }


        public void Cargar_cliente()
        {
            Clsclientes new_cliente = new Clsclientes();
            Console.Write("Ingrese la cedula del cliente: ");
            new_cliente.Cedula = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del cliente : ");
            new_cliente.Nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido del cliente: ");
            new_cliente.Apellido = Console.ReadLine();
            Console.Write("Ingrese el sexo del cliente: ");
            new_cliente.Sexo = Console.ReadLine();
            Console.Write("Ingrese la edad del cliente: ");
            new_cliente.Edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la direccion del cliente: ");
            new_cliente.Direccion = (Console.ReadLine());
            Console.Write("Ingrese el tipo de cliente: ");
            new_cliente.Tipo_c = (Console.ReadLine());
            lista_clientes.Add (new_cliente);

            /*Clsclientes cliente1 = new Clsclientes { Cedula = 1077425201, Nombre = "Ferney", Apellido = "Guardia", Sexo = "M", Edad = 34, Direccion = "Quibdo", Tipo_c = "oro" };
            Clsclientes cliente2 = new Clsclientes { Cedula = 1077425201, Nombre = "Carlos", Apellido = "Mena", Sexo = "M", Edad = 24, Direccion = "Istmina", Tipo_c = "plata" };
            Clsclientes cliente3 = new Clsclientes { Cedula = 1077425201, Nombre = "Ana", Apellido = "Palacios", Sexo = "F", Edad = 14, Direccion = "Condoto", Tipo_c = "platino" };
            Clsclientes cliente4 = new Clsclientes { Cedula = 1077425201, Nombre = "Alejandra", Apellido = "Mosquera", Sexo = "F", Edad = 64, Direccion = "Quibdo", Tipo_c = "oro" };

            lista_clientes.Add(cliente1);
            lista_clientes.Add(cliente2);
            lista_clientes.Add(cliente3);
            lista_clientes.Add(cliente4);*/
        }

        public void Imprimir_clientes()
        {
            Console.Clear();
            Console.WriteLine("LISTADO DE CLIENTES");
            foreach (Clsclientes p in lista_clientes)
            {
                Console.WriteLine("________________________");
                Console.WriteLine("Cedula: " + p.Cedula);
                Console.WriteLine("Nombre: " + p.Nombre);
                Console.WriteLine("Apellido: " + p.Apellido);
                Console.WriteLine("Sexo " + p.Sexo);
                Console.WriteLine("Edad: " + p.Edad);
                Console.WriteLine("Dirección: " + p.Direccion);
                Console.WriteLine("Tipo De Cliente: " + p.Tipo_c);
            }
        }


        public Clsclientes obtenerCliente()
        {

            Console.Clear();
            bool busc = false;
            Console.WriteLine("Ingrese la cedula del cliente");
            int cod_producto = int.Parse(Console.ReadLine());
            foreach (Clsclientes p in lista_clientes)
            {
                if (p.cedula == cod_producto)
                {
                    busc = true;
                    return p;


                }


            }
            if (busc == false)
            {
                Console.WriteLine("El Cliente con codigo " + cod_producto + " no esta en la lista");
                Console.ReadKey();
            }
            return null;

        }
    }
}
