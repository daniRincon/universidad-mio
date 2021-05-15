using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_listas
{
    class ClsVentas
    {
        private List<Cls_Productos> productos = new List<Cls_Productos>();
        private Clsclientes cliente = new Clsclientes();

        public void agregarCliente(Clsclientes codCliente)
        {
            
            cliente = codCliente;
        }

        public void agregaProductos(Cls_Productos codProductos)
        {
            productos.Add(codProductos);
        }

        public void listarCompra()
        {
            foreach (Cls_Productos p in productos)
            {
                    Console.WriteLine("________________________");
                    Console.WriteLine("Codido: " + p.Codigo);
                    Console.WriteLine("Nombre: " + p.Nombre);
                    Console.WriteLine("Marca: " + p.Marca);
                    Console.WriteLine("Precio " + p.Precio);
                    Console.WriteLine("Cantidad: " + p.Cantidad);
                    Console.WriteLine("________________________");
                    Console.WriteLine("\n________________________");
            }
            Console.ReadKey();
            //Listar cliente
        }
    }
}
