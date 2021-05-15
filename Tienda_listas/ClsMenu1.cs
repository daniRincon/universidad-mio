using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_listas
{
    public class ClsMenu1
    {
        private int opcion;
        private Cls_Productos productos = new Cls_Productos();
        private Clsclientes lis_cliente = new Clsclientes();
        // private ClsVentas venta = new ClsVentas();
        private List<Cls_Productos> ventas = new List<Cls_Productos>();
      
        private Clsclientes cliente = new Clsclientes();

        //private List<ClsVentas> ventasTotales = new List<ClsVentas>();
        float total = 0;
        public void Mostrar()
        {
            do
            {
                
                do
                {
                    Console.Clear();
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    Console.WriteLine("MENU DE OPCIONES");
                    Console.WriteLine("1 -> Agregar Producto");
                    Console.WriteLine("2 -> Listar Productos");
                    Console.WriteLine("3 -> Buscar Producto");
                    Console.WriteLine("4 -> Modificar Producto");
                    Console.WriteLine("5 -> Eliminar Producto");
                    Console.WriteLine("6 -> VENTAS ");
                    Console.WriteLine("7 ->Salir");
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    Console.Write("Elija una opción: ");
                    opcion = int.Parse(Console.ReadLine());
                    if (opcion < 1 || opcion > 7)
                    {
                        Console.WriteLine("Ingrese una opcion valida");
                        Console.ReadKey();

                    }

                } while (opcion < 1 || opcion > 7);

                switch (opcion)

                {
                    case 1:
                        {
                            //AGREGAR PRODUCTO          
                            
                            productos.Cargar_producto();
                            //lis_cliente.Cargar_cliente();
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            //LISTAR PRODUCTOS
                             
                            productos.Listar_productos();                           
                            //lis_cliente.Imprimir_clientes();
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            //BUSCAR PRODUCTO

                            productos.Buscar_producto();
                            Console.ReadKey();

                            break;
                        }
                    case 4:
                        {
                            //MODIFICAR PRODUCTO
                            break;
                        }
                    case 5:
                        {
                            //ELIMINAR PRODUCTO
                            break;
                        }
                    case 6:
                        {
                            //VENTAS - MENU 2

                            /*COMPRAR PRODUCTOS
                              LISTAR VENTAS
                              AGREGAR CLIENTE
                              MODIFICAR CLIENTE
                              ELIMINAR CLIENTE*/
                            int op;
                            do
                            {
                            Console.Clear();
                            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
                            Console.WriteLine("MENU DE VENTAS");
                            Console.WriteLine("1 -> Agregar cliente a la compra");
                            Console.WriteLine("2 -> comprar producto");
                            Console.WriteLine("3 -> modificar cliente");
                            Console.WriteLine("4 -> detalles de la venta");
                            Console.WriteLine("7 -> Salir");
                            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
                            Console.Write("Elija una opción: ");
                            op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    lis_cliente.Imprimir_clientes();
                                    Console.Write("Elija una cliente: ");
                                    cliente = lis_cliente.obtenerCliente();
                                    break;
                                case 2:
                                    int opcion;
                                    do
                                    {

                                        Console.Clear();
                                        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
                                        Console.WriteLine("Seleccione los productos");

                                        productos.Listar_productos();
                                        Console.WriteLine("Elija una opción : ");
                                        Console.WriteLine("1 agregar: ");
                                        Console.WriteLine("2 salir: ");

                                        opcion = int.Parse(Console.ReadLine());
                                        if (opcion == 1)
                                        {
                                            Cls_Productos productoSeleccionado = productos.obtenerProducto();
                                            ventas.Add(productoSeleccionado);
                                            Console.ReadKey();
                                        }
                                    } while (opcion == 1);
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("________________________");
                                    Console.WriteLine("Cedula: " + cliente.Cedula);
                                    Console.WriteLine("Nombre: " + cliente.Nombre);
                                    Console.WriteLine("Apellido: " + cliente.Apellido);
                                    Console.WriteLine("Sexo " + cliente.Sexo);
                                    Console.WriteLine("Edad: " + cliente.Edad);
                                    Console.WriteLine("Dirección: " + cliente.Direccion);
                                    Console.WriteLine("Tipo De Cliente: " + cliente.Tipo_c);
                                    Console.WriteLine("________________________");
                                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
                                    Console.WriteLine("Prooducto de la venta");
                                    foreach (Cls_Productos p in ventas)
                                    {
                                        Console.WriteLine("________________________");
                                        Console.WriteLine("Codido: " + p.Codigo);
                                        Console.WriteLine("Nombre: " + p.Nombre);
                                        Console.WriteLine("Marca: " + p.Marca);
                                        Console.WriteLine("Precio " + p.Precio);
                                        Console.WriteLine("Comprada: " + p.cComprada);
                                        Console.WriteLine("________________________");
                                            total += p.Precio * p.cComprada;
                                    }
                                        Console.WriteLine("Total de compra: " + total);
                                        Console.ReadKey();
                                    break;
                                default:break;
                            }
                            } while (op!=7);
                            break;

                        }
                    case 7:
                        {
                            //Salir
                            break;
                        }
                   
                }

            } while (opcion!=7);


        }
    }
}
