using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace TP_02_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuración de la pantalla
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight - 2);

            // Nombre del alumno
            Console.Title = "";

            Taller taller = new Taller(6);

            Ciclomotor c1 = new Ciclomotor(Vehiculo.EMarca.BMW, "ASD012", ConsoleColor.Black);
            Ciclomotor c2 = new Ciclomotor(Vehiculo.EMarca.HarleyDavidson, "LEM666", ConsoleColor.Red);
            Sedan m1 = new Sedan(Vehiculo.EMarca.Toyota, "HJK789", ConsoleColor.White);
            Sedan m2 = new Sedan(Vehiculo.EMarca.Chevrolet, "IOP852", ConsoleColor.Blue, Sedan.ETipo.CincoPuertas);
            Suv a1 = new Suv(Vehiculo.EMarca.Ford, "QWE968", ConsoleColor.Gray);
            Suv a2 = new Suv(Vehiculo.EMarca.Renault, "TYU426", ConsoleColor.DarkBlue);
            Suv a3 = new Suv(Vehiculo.EMarca.BMW, "IOP852", ConsoleColor.Green);
            Suv a4 = new Suv(Vehiculo.EMarca.Honda, "ASD913", ConsoleColor.Green);

            // Agrego 8 ítems (los últimos 2 no deberían poder agregarse ni el m1 repetido) y muestro
            taller += c1;
            taller += c2;
            taller += m1;
            taller += m1;
            taller += m2;
            taller += a1;
            taller += a2;
            taller += a3;
            taller += a4;

            Console.WriteLine(taller.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Quito 2 items y muestro
            taller -= c1;
            taller -= new Ciclomotor(Vehiculo.EMarca.Honda, "ASD913", ConsoleColor.Red);

            Console.WriteLine(taller.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Vuelvo a agregar c2
            taller += c2;

            // Muestro solo Moto
            Console.WriteLine(Taller.Listar(taller, Taller.ETipo.Ciclomotor));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Automovil
            Console.WriteLine(Taller.Listar(taller, Taller.ETipo.Sedan));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Camioneta
            Console.WriteLine(Taller.Listar(taller, Taller.ETipo.SUV));
            Console.WriteLine("<-------------PRESIONE UNA TECLA PARA SALIR------------->");
            Console.ReadKey();
        }
    }
}
