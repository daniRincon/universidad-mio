using System;
using System.Collections.Generic;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("");
            Console.WriteLine("LISTA DE CONTACTOS");
            Console.WriteLine("");
            Console.WriteLine("----------------");

            Console.WriteLine("ingrese la cantidad de contactos que tenga");
            int conta = int.Parse(Console.ReadLine());
            Console.Clear();

            string[] nombres = new string[conta];
            string[] numero = new string[conta];
            string[] fechaN = new string[conta];
            string[] barrio = new string[conta];
            int con = 1;
            for(int i = 0; i < conta; i++)
            {
                Console.WriteLine("ingrese nombre del contacto " + con);
                nombres[i] = Console.ReadLine();
                Console.WriteLine("ingrese el numero del contacto " + con);
                numero[i] = Console.ReadLine();
                Console.WriteLine("ingrese la fecha de nacimiento del contacto " + con);
                fechaN[i] = Console.ReadLine();
                Console.WriteLine("ingrese el barrio del contacto " + con);
                barrio[i] = Console.ReadLine();
                con++;
                Console.Clear();
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

            for(int i = 0; i < conta; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(0, 1 + i);
                Console.WriteLine(nombres[i]);
                Console.SetCursorPosition(20, 1 + i);
                Console.WriteLine(numero[i]);
                Console.SetCursorPosition(40, 1 + i);
                Console.WriteLine(fechaN[i]);
                Console.SetCursorPosition(70, 1 + i);
                Console.WriteLine(barrio[i]);
            }

            Console.ReadKey();

        }
    }
}
