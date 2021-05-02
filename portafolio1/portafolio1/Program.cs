using System;

namespace portafolio1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*La universidad Uniclaretiana necesita registrar los pagos de los estudiantes, por tal razón, 
             * se pidió a los estudiantes de Estructuras de datos desarrollar un algoritmo que permita lo siguiente: 
             * Registrar n cantidad de estudiantes con los siguientes datos 
             * (Cedula, Nombre, Genero, valor de la matrícula y Valor a pagar)


        En un menú debe permitir las siguientes opciones:
        1. Registrar n cantidad de estudiantes
        2. Listar los de estudiantes que pagaron la matricula completa y el valor pagado.
        3. Listar los de estudiantes que pagaron parcialmente y el valor que debe.
        4. Mostrar la sumatoria del pago de todos los estudiantes y la sumatoria de la deuda de todos los estudiantes.
        5. Qué porcentaje de hombres pago completo y que porcentaje de mujeres pago parcialmente.

            */


            string[] nombre;
            string[] cedula;
            int[] genero;
            double[] valor_Matricula;
            double[] valor_a_pagar;
            int  menu, vec, hom = 0, muj = 0;
            double con = 0, suma=0, acuh = 0, acum = 0;

            Console.WriteLine("BIENVENIDO A LA SUCURSAL DE PAGOS UNICLARETIANA");
            Console.Write("");

            Console.WriteLine("Cuantos Usuarios van a pagar el recibo");
            vec = Convert.ToInt32(Console.ReadLine());


            nombre = new string[vec];
            cedula = new string[vec];
            valor_Matricula = new double[vec];
            valor_a_pagar = new double[vec];
            genero = new int[vec];


            Console.Clear();


            do
            {

                Console.WriteLine("");
                Console.WriteLine("Seleccione una opción según el siguente menu");
                Console.WriteLine("");
                Console.WriteLine("1.Registre n cantidad de estudiantes");
                Console.WriteLine("2.Estudiantes que pagaron completo");
                Console.WriteLine("3.Estudante que pagaron parcialmente");
                Console.WriteLine("4.Suma de pagos completos y suma de pagos parciales");
                Console.WriteLine("5.Porcentaje de hombres que pagaron completos y de mujeres que pago parcialmente");
                Console.WriteLine("6.Salir");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                switch (menu)
                {
                    //registrar a los usuarios 
                    case 1:

                        for (int i = 0; i < vec; i++)
                        {
                            Console.WriteLine("Ingrese su nombre");
                            nombre[i] = Console.ReadLine();
                            Console.WriteLine("Ingrese su cedula");
                            cedula[i] = Console.ReadLine();

                            Console.WriteLine("Ingrese '1' si su genero es masculino ó '2' si es femenino");
                            genero[i] = Convert.ToInt32(Console.ReadLine());
                            switch (genero[i])
                            {
                                case 1:

                                    hom++;
                                    break;

                                case 2:

                                    muj++;
                                    break;
                            }
                            Console.WriteLine("Ingrese el valor de la matricula");
                            valor_Matricula[i] = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese cuanto va a pagar");
                            valor_a_pagar[i] = Convert.ToDouble(Console.ReadLine());
                            //con++;


                            con += valor_a_pagar[i];



                            Console.Clear();

                        }

                        break;


                    //lista de los estudantes que pagaron completo
                    case 2:


                        for (int i = 0; i < vec; i++)
                        {
                            if (valor_Matricula[i] == valor_a_pagar[i])
                            {
                                Console.WriteLine("Su Nombre es: " + nombre[i]);
                                Console.WriteLine("Su Identificacion: " + cedula[i]);
                                if (genero[i] == 1)
                                {
                                    Console.WriteLine("Su Genero es:Hombre");


                                }
                                if (genero[i] == 2)
                                {
                                    Console.WriteLine("Su Genero es: Mujer");
                                }
                                if (genero[i] != 1 && genero[i] != 2)
                                {
                                    Console.WriteLine("No seleciono ningun genero");
                                }

                                Console.WriteLine("El Valor de la Matricula es: " + valor_Matricula[i]);
                                Console.WriteLine("El Valor que Pagó es: " + valor_a_pagar[i]);
                                Console.WriteLine("");


                            }


                        }


                        break;


                    //lista de los estudiantes que pagaron parcialmente
                    case 3:
                        double debe = 0;

                        for (int i = 0; i < vec; i++)
                        {
                            if (valor_a_pagar[i] < valor_Matricula[i])
                            {
                                debe = valor_Matricula[i] - valor_a_pagar[i];
                                Console.WriteLine("Su Nombre es: " + nombre[i]);
                                Console.WriteLine("Su Identificación es: " + cedula[i]);
                                if (genero[i] == 1)
                                {
                                    Console.WriteLine("Su Genero es: Hombre");
                                }
                                if (genero[i] == 2)
                                {
                                    Console.WriteLine("Su Genero es: Mujer");


                                }
                                if (genero[i] != 1 && genero[i] != 2)
                                {
                                    Console.WriteLine("No seleciono ningun genero");
                                }
                                Console.WriteLine("El Valor de la Matricula es: " + valor_Matricula[i]);
                                Console.WriteLine("El Valor que pagó es: " + valor_a_pagar[i]);
                                Console.WriteLine("El Valor que quedó Debiendo es: " + debe);
                                Console.WriteLine("");

                                suma += debe;



                            }



                        }


                        break;

                    //suma de pago completo y parcial
                    case 4:


                        Console.WriteLine("La suma total es: " + con);
                        Console.WriteLine("");
                        Console.WriteLine("La suma de deuda es: " + suma);



                        break;


                    //porcentaje hombres Pcompleto y mujeres Pparcialmente
                    case 5:

                        double porh = 0, porm = 0;


                        for (int i = 0; i < vec; i++)
                        {
                            if ( valor_Matricula[i] == valor_a_pagar[i] && genero[i] == 1  )
                            {
                                acuh++;
                                porh = (acuh / hom) * 100;

                            }

                        }


                        for(int i=0; i < vec; i++)
                        {
                            if (valor_a_pagar[i] < valor_Matricula[i] && genero[i] == 2)
                            {
                                acum++;
                                porm = (acum / muj) *100;

                            }
                        }



                        Console.WriteLine("el porcentaje de los hombres que pagaron completo es: " + porh + "%");
                        Console.WriteLine("");
                        Console.WriteLine("el porcentaje de las mujeres que pagaron parcialmente es: " + porm + "%");

                        break;

                    case 6:
                        Console.WriteLine("Ha salido del programa");
                        Console.WriteLine("");
                        Console.WriteLine("Te esperamos para la proxima");
                        break;
                }






            } while (menu!=6);


        }
    }
}
