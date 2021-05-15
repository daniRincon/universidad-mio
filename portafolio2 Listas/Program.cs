using System;


/*
 PROBLEMA A RESOLVER

Con el objetivo de apoyar a los locales afectados por la pandemia se crea un bono de 5.000.000 para los locales que tengan más de 5 empleados
y tuvieron pérdidas superiores a 15 millones de pesos.

Crear un programa utilizando listas que permita censar los establecimientos comerciales de la ciudad de Quibdó,
de los cuales se debe permitir actualizar sus datos. De cada establecimiento se debe registrar como mínima los siguientes datos 
(nit, nombre, barrio, servicio que ofrece, jornada que trabaja (día - noche), cantidad de empleados actuales,
cantidad de empleados despedidos perdidas en dinero por pandemia). 2p

• Listar los establecimientos nocturnos con pérdidas superiores a 50 millones. 1p
• Listar los establecimientos que trabajan por el día que despidieron empleados, el total de empleados despedidos y total de las perdidas. 1p
• Listar los establecimientos que recibieron el bono y el total entregado en bonos. 1p
 */


namespace portafolio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Menu mimunu = new Menu();
            mimunu.menun();
        }
    }
}
