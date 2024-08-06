using Ejercicio_sobre_Herencia;
using System;
using System.Collections.Generic;

public class Bodega : Marca
{
    public List<Producto> Celulares { get; set; }
    public List<Producto> Tablets { get; set; }
    public List<Producto> Laptops { get; set; }

    public Bodega()
    {
        Celulares = new List<Producto>();
        Tablets = new List<Producto>();
        Laptops = new List<Producto>();
    }

    public void AddCellphone()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("        AGREGAR CELULAR");
        Console.ResetColor();
        Console.WriteLine("-------------------------------\n");

        Console.Write("Escribe Nombre: ");
        string name = Console.ReadLine();

        Console.Write("Escribe Marca: ");
        string brand = Console.ReadLine();
        AddBrand(brand); 

        Console.Write("Escribe ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escribe la descripción: ");
        string description = Console.ReadLine();

        Producto nuevoCelular = new Producto(id, name, description);
        Celulares.Add(nuevoCelular);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nProducto {name}, Correctamente registrado");
        Console.ResetColor();
        Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
        Console.ReadKey();
    }

    public void AddTablet()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("        AGREGAR TABLET");
        Console.ResetColor();
        Console.WriteLine("-------------------------------\n");

        Console.Write("Escribe Nombre: ");
        string name = Console.ReadLine();

        Console.Write("Escribe Marca: ");
        string brand = Console.ReadLine();
        AddBrand(brand); 

        Console.Write("Escribe ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escribe la descripción: ");
        string description = Console.ReadLine();

        Producto nuevaTablet = new Producto(id, name, description);
        Tablets.Add(nuevaTablet);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nProducto {name}, Correctamente registrado");
        Console.ResetColor();
        Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
        Console.ReadKey();
    }

    public void AddLaptop()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("        AGREGAR LAPTOP");
        Console.ResetColor();
        Console.WriteLine("-------------------------------\n");

        Console.Write("Escribe Nombre: ");
        string name = Console.ReadLine();

        Console.Write("Escribe Marca: ");
        string brand = Console.ReadLine();
        AddBrand(brand); 

        Console.Write("Escribe ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escribe la descripción: ");
        string description = Console.ReadLine();

        Producto nuevaLaptop = new Producto(id, name, description);
        Laptops.Add(nuevaLaptop);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nProducto {name}, Correctamente registrado");
        Console.ResetColor();
        Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
        Console.ReadKey();
    }

    public void SearchProduct()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("        BUSCAR PRODUCTO");
        Console.ResetColor();
        Console.WriteLine("-------------------------------\n");

        Console.Write("Escribe el id: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        var product = Celulares.FirstOrDefault(p => p.Id == searchId)
                    ?? Tablets.FirstOrDefault(p => p.Id == searchId)
                    ?? Laptops.FirstOrDefault(p => p.Id == searchId);

        if (product != null)
        {
            Console.WriteLine($"Producto encontrado: ID: {product.Id}, Nombre: {product.Name}, Descripción: {product.Description}");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }

        Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
        Console.ReadKey();
    }

    public void ShowProduct()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("       LISTA DE PRODUCTOS");
        Console.ResetColor();
        Console.WriteLine("-------------------------------\n");

        Console.WriteLine("\nCELULARES: ");
        foreach (var cellphone in Celulares)
        {
            Console.WriteLine($"ID: {cellphone.Id}, Nombre: {cellphone.Name}, Descripción: {cellphone.Description}");
        }

        Console.WriteLine("\nTABLETS: ");
        foreach (var tablet in Tablets)
        {
            Console.WriteLine($"ID: {tablet.Id}, Nombre: {tablet.Name}, Descripción: {tablet.Description}");
        }

        Console.WriteLine("\nLAPTOPS: ");
        foreach (var laptop in Laptops)
        {
            Console.WriteLine($"ID: {laptop.Id}, Nombre: {laptop.Name}, Descripción: {laptop.Description}");
        }

        Console.WriteLine("\nPresione cualquier tecla para regresar al menú principal...");
        Console.ReadKey();
    }
}

