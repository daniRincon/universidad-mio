using System;
using System.Collections.Generic;
using System.Linq;


namespace Juego1{
    
    class Listas{
    
        static void Main(string[] args){
        
         List<string> juego = new List<string>();

Console.WriteLine("*Deportes*\n");

            juego.Add("Golf");
            juego.Add("Basket");
            juego.Add("Micro");
            juego.Add("Tenis");
            juego.Add("Basebol");
            juego.Add("Hockie");

for (int i = 0; i < juego.Count(); i++){
            
 Console.WriteLine(juego[i]);
 
 }

Console.Write("\n1: Remover");
Console.Write("\n2: Añadir a la lista");
Console.Write("\n3: Añadir deporte a una posicion");
Console.Write("\n4: Mostrar lista");
Console.Write("\n0: Salir");

Console.Write("\n\nOpcion: ");
int op = int.Parse(Console.ReadLine());

Console.Clear();
 
while(op != 0){

switch(op){
    
case 1:

int remove;

Console.WriteLine("\nRemover\n");

for (int i = 0; i < juego.Count(); i++){
Console.WriteLine(juego[i]+" - posicion: "+i);
}

Console.Write("\nPosicion q desea remover: ");
remove = int.Parse(Console.ReadLine());
juego.RemoveAt(remove);

Console.Write("\nEl deporte de la posicion "+remove+ " fue removido\n");
                for (int i = 0; i < juego.Count(); i++)
                        {
                            Console.WriteLine(juego[i] + " - posicion: " + i);
                        }

                        break;

case 2:

string Add;

Console.WriteLine("\nAñadir a la lista\n");

for (int i = 0; i < juego.Count(); i++){
Console.WriteLine(juego[i]+" - posicion: "+i);
}

Console.Write("\nNombre que desea añadir: ");
Add = Console.ReadLine();
juego.Add(Add);

Console.Write("\nEl deporte "+Add+ " fue añadido\n");

                        for (int i = 0; i < juego.Count(); i++)
                        {
                            Console.WriteLine(juego[i] + " - posicion: " + i);
                        }
                        break;

case 3:

string Ins1, Ins2;
Console.WriteLine("\nAñadir deporte a una posicion\n");

for (int i = 0; i < juego.Count(); i++){
Console.WriteLine(juego[i]+" - posicion: "+i);
}

Console.Write("\n\nInserte posicion para el deporte: ");
Ins1 = Console.ReadLine();

//nombre del elemento que desea añadir
Console.Write("\nInserte nombre del nuevo deporte: ");
Ins2 = Console.ReadLine();

juego.Insert(int.Parse(Ins1), Ins2);

Console.Write("\nEl deporte: "+Ins2+ " fue añadido a la posicion: "+Ins1+"\n");


                        for (int i = 0; i < juego.Count(); i++)
                        {
                            Console.WriteLine(juego[i] + " - posicion: " + i);
                        }
                        break;


case 4:

Console.Write("\nMostrar lista\n\n");

for (int i = 0; i < juego.Count(); i++){
Console.WriteLine(juego[i]+" - posicion: "+i);
}

break;
}

Console.Write("\n1: Remover");
Console.Write("\n2: Añadir a la lista");
Console.Write("\n3: Añadir deporte a una posicion");
Console.Write("\n4: Mostrar lista");
Console.Write("\n0: Salir");

Console.Write("\n\nOpcion: ");
op = int.Parse(Console.ReadLine());

Console.Clear();

}       
Console.Write("Programa Finalizado");
    }
  }
}
