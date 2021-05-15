using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_listas
{
    class Cls_Productos
    {

        private static int _codigo=-1;
        public int codigo = 0;
        public string nombre="xxx";
        public string marca = "xxx";
        public int precio=100;
        public int cantidad=10;
        public int ccomprada = 0;
        List<Cls_Productos> Lista_productos = new List<Cls_Productos>();




        public Cls_Productos()
        {
            _codigo++;
            Codigo = _codigo;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public int cComprada { get => ccomprada; set => ccomprada = value; }

        public void Cargar_producto()
        {
           
            Cls_Productos n_producto = new Cls_Productos();
            Console.Write("Ingrese el codigo del roducto: ");
            n_producto.codigo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del producto: ");
            n_producto.Nombre = Console.ReadLine();
            Console.Write("Ingrese la marca del producto: ");
            n_producto.marca = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            n_producto.precio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad del producto: ");
            n_producto.cantidad = int.Parse(Console.ReadLine());
            Lista_productos.Add(n_producto);
            Console.WriteLine(" El preducto fue agregado correctamente");
            //Console.ReadKey();
            /*Cls_Productos prod_nuevo = new Cls_Productos { Nombre = "Queso", Marca = "Caqueta", Precio = 18000, Cantidad = 100 };
            Cls_Productos prod1 = new Cls_Productos { Nombre = "Papaya", Marca = "M", Precio = 1800, Cantidad = 50 };
            Cls_Productos prod2 = new Cls_Productos { Nombre = "Yuca", Marca = "Atrato", Precio = 1100, Cantidad = 20 };
            Cls_Productos prod3 = new Cls_Productos { Nombre = "Platano", Marca = "Arton", Precio = 1500, Cantidad = 60 };
            Cls_Productos prod4 = new Cls_Productos {  Nombre = "Arroz", Marca = "Diana", Precio = 2500, Cantidad = 10 };
            Cls_Productos prod5 = new Cls_Productos { Nombre = "Leche", Marca = "Colanta", Precio = 3800, Cantidad = 32 };
            Lista_productos.Add(prod1);
            Lista_productos.Add(prod2);
            Lista_productos.Add(prod3);
            Lista_productos.Add(prod4);
            Lista_productos.Add(prod5);
            Lista_productos.Add(prod_nuevo);*/

            Console.WriteLine("El preducto fue agregado correctamente");
            //Console.ReadKey();

        }

        public void Listar_productos()
        {
           
            Console.WriteLine("LISTADO DE PPRODUCTOS");
            foreach (Cls_Productos p in Lista_productos)
            {
                Console.WriteLine("________________________");
                Console.WriteLine("Codido: " + p.Codigo);
                Console.WriteLine("Nombre: " + p.Nombre);
                Console.WriteLine("Marca: " + p.Marca);
                Console.WriteLine("Precio " + p.Precio);
                Console.WriteLine("Cantidad: " + p.Cantidad);
            }
        }

        public void Buscar_producto()
        {

            Console.Clear();
            bool busc = false;
            Console.WriteLine("Ingrese al codigo del produdto");
            int cod_producto = int.Parse(Console.ReadLine());
            foreach (Cls_Productos p in Lista_productos)
            {
                if (p.Codigo == cod_producto)

                {
                    Console.WriteLine("________________________");
                    Console.WriteLine("Codido: " + p.Codigo);
                    Console.WriteLine("Nombre: " + p.Nombre);
                    Console.WriteLine("Marca: " + p.Marca);
                    Console.WriteLine("Precio " + p.Precio);
                    Console.WriteLine("Cantidad: " + p.Cantidad);
                    busc = true;
                }


            }
            if (busc == false)
            {
                Console.WriteLine("El Producto con codigo " + cod_producto + " no esta en la lista");

            }

            Console.ReadKey();

        }

        public Cls_Productos obtenerProducto()
        {

            Console.Clear();
            bool busc = false;
            Console.WriteLine("Ingrese al codigo del produdto");
            int cod_producto = int.Parse(Console.ReadLine());
            foreach (Cls_Productos p in Lista_productos)
            {
                if (p.Codigo == cod_producto)
                {
                    busc = true;
                    Console.WriteLine("Ingrese la cantidad a comprar:");
                    p.cComprada = int.Parse(Console.ReadLine());
                    p.Cantidad -= p.cComprada;
                    return p;                   
                  
                }


            }
            if (busc == false)
            {
                Console.WriteLine("El Producto con codigo " + cod_producto + " no esta en la lista");
                //Console.ReadKey();
            }
            return null;            

        }

        public void Modificar_producto()
        {
            Console.Clear();
            bool busc = false;
            Console.WriteLine("Ingrese el codigo del producto que desea modificar: ");
            int Cod_producto = int.Parse(Console.ReadLine());
            foreach (Cls_Productos p in Lista_productos)
            {
                if (Cod_producto == p.Codigo)
                {
                    Console.WriteLine("________________________");
                    Console.WriteLine("Codido: " + p.Codigo);
                    Console.WriteLine("Nombre: " + p.Nombre);
                    Console.WriteLine("Marca: " + p.Marca);
                    Console.WriteLine("Precio " + p.Precio);
                    Console.WriteLine("Cantidad: " + p.Cantidad);
                    Console.WriteLine("________________________");

                    Console.WriteLine("\n________________________");
                    Console.Write("Ingrese el nuevo nombre del producto: ");
                    p.Nombre = Console.ReadLine();
                    Console.Write("Ingrese la nueva marca del producto: ");
                    p.marca = Console.ReadLine();
                    Console.Write("Ingrese el nuevo precio del producto: ");
                    p.precio = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nueva cantidad del producto: ");
                    p.Cantidad = int.Parse(Console.ReadLine());                  
                    Console.WriteLine(" El preducto fue modificado correctamente");
                    busc = true;
                    Console.ReadKey();
                }

            }

            if (busc == false)
            {
                Console.WriteLine("El Producto con codigo " + Cod_producto + " no esta en la lista");

            }

            Console.ReadKey();
        }


        /*public void A_producto()
        {
            Cls_Productos prod1 = new Cls_Productos { Codigo = 01, Nombre = "Papaya", Marca = "M", Precio = 1800, Cantidad = 50 };
            Cls_Productos prod2 = new Cls_Productos { Codigo = 02, Nombre = "Yuca", Marca = "Atrato", Precio = 1100, Cantidad = 20 };
            Cls_Productos prod3 = new Cls_Productos { Codigo = 03, Nombre = "Platano", Marca = "Arton", Precio = 1500, Cantidad = 60 };
            Cls_Productos prod4 = new Cls_Productos { Codigo = 04, Nombre = "Arroz", Marca = "Diana", Precio = 2500, Cantidad = 10 };
            Cls_Productos prod5 = new Cls_Productos { Codigo = 01, Nombre = "Leche", Marca = "Colanta", Precio = 3800, Cantidad = 32 };       
            Lista_productos.Add(prod1);
            Lista_productos.Add(prod2);
            Lista_productos.Add(prod3);
            Lista_productos.Add(prod4);
            Lista_productos.Add(prod5);
        }*/




    }

}
