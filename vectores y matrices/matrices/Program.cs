using System;

namespace matrices
{
    class Program
    {
        static void Main(string[] args_2)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("");
            Console.WriteLine("LISTA DE CONTACTOS");
            Console.WriteLine("");
            Console.WriteLine("----------------");

            
            Console.WriteLine("ingrese la cantidad de contactos que va agregar");
            

            int colum = int.Parse(Console.ReadLine());
            Console.Clear();

            string[,] contactos = new string[4,colum];
            string[,] name = new string[4, colum];
            string[,] dianci = new string[4, colum];
            string[,] barrio = new string[4, colum];

            int con = 1;



            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < colum; j++)
                {
                    //if(colum>=4 )

                    Console.WriteLine("ingrese nombre del contacto " + con);
                    name[i, j] = Console.ReadLine();
                    Console.WriteLine("ingrese numero del contacto " + con);
                    contactos[i, j] = Console.ReadLine();
                    Console.WriteLine("ingrese dia nacimiento del contacto " + con);
                    dianci[i, j] = Console.ReadLine();
                    Console.WriteLine("ingrese barrio del contacto " + con);
                    barrio[i, j] = Console.ReadLine();
                    con++;
                    Console.Clear();
                }
            }


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(0, 0);
            Console.Write("NOMBRES");
            Console.SetCursorPosition(20, 0);
            Console.Write("NUMEROS");
            Console.SetCursorPosition(40, 0);
            Console.Write("FECHAS DE NACIMIENTOS");
            Console.SetCursorPosition(70, 0);
            Console.Write("BARRIOS");




            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.SetCursorPosition(0, 1 + i + j );
                    Console.WriteLine(name[i, j]);
                    Console.SetCursorPosition(20, 1 + i + j);
                    Console.WriteLine(contactos[i, j]);
                    Console.SetCursorPosition(40, 1 + i + j);
                    Console.WriteLine(dianci[i, j]);
                    Console.SetCursorPosition(70, 1 + i + j);
                    Console.WriteLine(barrio[i, j]);
                }
            }





            Console.ReadKey();

        }
    }
}
