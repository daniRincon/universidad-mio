using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_p
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lis_nombres = new List<string>()
            {
              "Juan Mena",
              "Pedro moreno",
              "Maria Lagarejo"
            };
            List<int> lis_edad = new List<int>()
            { 25,35,60 };
            lis_nombres.Add("Ferney Guardia");


            lis_nombres.AddRange(new string[]
            {
                  "Juan David",
                  "Juan Carlos",
                  "Miguel Andrade"
            });

            foreach (string nombre in lis_nombres)
            {
                Console.WriteLine(nombre);
            }
            Console.ReadKey();

            Console.WriteLine("\nNUEVA LISTA");
            lis_nombres.Remove("Juan Carlos");
            lis_nombres.RemoveAt(2);




            foreach (string nombre in lis_nombres)
            {
                Console.WriteLine(nombre);
            }

            Console.ReadKey();


            string nom;
            int pus;

            Console.WriteLine("INgrese el tamaño de la lista");
            pus = int.Parse(Console.ReadLine());

            Console.WriteLine("INgrese su nombre");
            nom = Console.ReadLine();

            List<Estudiante> listEstudiante = new List<Estudiante>(pus)
            {
                new Estudiante() { Nombre = nom, Semestre = 5, Promedio = 5.5 },

            };

            for (int i = 0; i < pus; i++)
            {
                Console.WriteLine(listEstudiante[i].Nombre + " Es del  " + listEstudiante[i].Semestre + " Semestre");
            }
            Console.ReadKey();

        }


    }


}


class Estudiante
{
    public string Nombre { get; set; }
    public int Semestre { get; set; }
    public double Promedio { get; set; }
}


