using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_sobre_Herencia
{
    public class Marca
    {
        public List<string> Marcas { get; set; } 

        public Marca()
        {
            Marcas = new List<string>();
        }

        public void AddBrand(string brandName)
        {
            Marcas.Add(brandName);
            Console.WriteLine($"Marca {brandName} agregada correctamente.");
        }

        public void ShowBrands()
        {
            Console.WriteLine("Listado de Marcas:");
            foreach (var marca in Marcas)
            {
                Console.WriteLine(marca);
            }
        }
    }
}


