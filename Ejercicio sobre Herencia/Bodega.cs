using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_sobre_Herencia
{

    //Entender cómo agregar las listas y cómo estas se van a relacionar
    //Con el mismo hecho de qué ahora tengamos herencia 
    public class Bodega : Marcas
    {


        public string AddCellphone()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        AGREGAR CELULAR");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");
            string NewElectronic;



            return null;
        }
        public string AddTablet()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        AGREGAR TABLET");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");
            string NewElectronic;



            return null;
        }
        public string AddLaptop()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        AGREGAR LAPTOP");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");
            string NewElectronic;



            return null;
        }
        public void ShowProduct()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       MOSTRAR PRODUCTO");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");

        }
        public void SearchProduct()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        BUSCAR PRODUCTO");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");

        }
        
    }
    
   
    
}
