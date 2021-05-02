﻿using System;

namespace clase2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
                En emprendedor monto un negocio para vender celulares con 5 modelos diferentes, 
                para lo cual necesita un algoritmo que le permita:

                • Crear el inventario con los modelos, precios y cantidades
                • Registrar las ventas de la semana
                • Imprimir un reporte con las ventas de la semana y el inventario 
                • Mostrar un mensaje cuando un modelo de teléfono tenga 2 unidades o menos en el inventario
                Nota: El programa debe permitir vender solo las cantidades que hay en el inventario.
            */

            String[] modelo;
            double[] precio;
            int[] cantidad;

            String[] remo;
            double[] repre;
            int[] regcan;

            string dis;
            int cuan, menu, cant;

            Console.WriteLine("BIENVENIDO A CELULAR HACKDACK");
            Console.WriteLine("");


            Console.WriteLine("¿Cuantos dispositivo desea registrar?");
            cuan = Convert.ToInt32(Console.ReadLine());

            modelo = new string[cuan];
            precio = new double[cuan];
            cantidad = new int[cuan];

            for (int i = 0; i < cuan; i++)
            {
                Console.WriteLine("Modelos que desea agregar");
                modelo[i] = Console.ReadLine();

                Console.WriteLine("Precio que desea agregar");
                precio[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Cantida que desea agregar");
                cantidad[i] = int.Parse(Console.ReadLine());

            }

            Console.Clear();
            do
            {


                Console.WriteLine("");
                Console.WriteLine("1.Venta de Dispositivo");
                Console.WriteLine("2. Registar ventas por semanas");
                Console.WriteLine("3. imprimir el reporte de ventas e inventario");
                Console.WriteLine("4. salir");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                        for (int i = 0; i < cuan; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Dispositivos que tenemos actualmente");
                            Console.Write("");
                            Console.WriteLine("Nombre del Dispositivo : " + modelo[i]);
                            Console.Write("");
                            Console.WriteLine("Precio del Dispositivo : " + precio[i]);
                            Console.Write("");
                            Console.WriteLine("Cantidad de Dispositivo : " + cantidad[i]);
                        }


                        Console.WriteLine("¿Qué dispositivo desea comprar?");
                        dis = Console.ReadLine();
                        Console.WriteLine("¿Qué cantidad desea comprar?");
                        cant = int.Parse(Console.ReadLine());
                        for (int i = 0; i < cuan; i++)
                        {
                            if (dis == modelo[i])
                            {
                                cantidad[i] -= cant;

                            }
                        }


                        for (int i = 0; i < cuan; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Dispositivos que tenemos actualmente");
                            Console.Write("");
                            Console.WriteLine("Nombre del Dispositivo : " + modelo[i]);
                            Console.Write("");
                            Console.WriteLine("Precio del Dispositivo : " + precio[i]);
                            Console.Write("");
                            Console.WriteLine("Cantidad de Dispositivo : " + cantidad[i]);
                        }



                        break;


                    case 2:
                        Console.WriteLine("Registro de las ventas semanales");
                        cuan = Convert.ToInt32(Console.ReadLine());

                        remo = new string[cuan];
                        repre = new double[cuan];
                        regcan = new int[cuan];

                        for (int i = 0; i < cuan; i++)
                        {
                            Console.WriteLine("Modelos que desea agregar");
                            remo[i] = Console.ReadLine();

                            Console.WriteLine("Precio que desea agregar");
                            repre[i] = double.Parse(Console.ReadLine());

                            Console.WriteLine("Cantida que desea agregar");
                            regcan[i] = int.Parse(Console.ReadLine());




                            Console.WriteLine("");
                            Console.WriteLine("Dispositivos que se vendieron en la semana");
                            Console.Write("");
                            Console.WriteLine("Nombre del Dispositivo : " + remo[i]);
                            Console.Write("");
                            Console.WriteLine("Precio del Dispositivo : " + repre[i]);
                            Console.Write("");
                            Console.WriteLine("Cantidad de Dispositivo : " + regcan[i]);

                        }


                        break;

                    case 3:






                        for (int i = 0; i < cuan; i++)
                        {

                            Console.WriteLine("");
                            Console.WriteLine("Dispositivos que tenemos actualmente");
                            Console.Write("");
                            Console.WriteLine("Nombre del Dispositivo : " + modelo[i]);
                            Console.Write("");
                            Console.WriteLine("Precio del Dispositivo : " + precio[i]);
                            Console.Write("");
                            Console.WriteLine("Cantidad de Dispositivo : " + cantidad[i]);
                        }





                        break;



                    case 4:

                        Console.WriteLine("ha Salido del programa");
                        break;


                }

            } while (menu != 4);




        }
    }
}
