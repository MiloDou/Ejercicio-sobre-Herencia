using System;
using System.Collections.Generic;
using System.Linq;

namespace Herencia
{
    class Electronicos
    {
        static void Main(string[] args)
        {
            Bodega LaBodega = new Bodega();

            while (true)
            {
                try
                {
                    ShowMenu();
                    Console.Write("Elige una opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            MenuAdd(LaBodega);
                            break;
                        case 2:
                            LaBodega.ShowProduct();
                            break;
                        case 3:
                            LaBodega.SearchProduct();
                            break;
                        case 4:
                            Exit();
                            return; 
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error encontrado: " + ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Error encontrado: " + ex.Message);
                }
                Console.ReadKey();
            }
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("             MENÚ");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Mostrar Producto");
            Console.WriteLine("3. Buscar Producto");
            Console.WriteLine("4. Salir");
        }

        static void Exit()
        {
            Console.WriteLine("Ciao user...");
            Console.WriteLine("Presiona ENTER para salir");
        }

        static void MenuAdd(Bodega LaBodega)
        {
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("-------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("        AGREGAR PRODUCTO");
                    Console.ResetColor();
                    Console.WriteLine("-------------------------------\n");
                    Console.WriteLine("1. Agregar Celular");
                    Console.WriteLine("2. Agregar Tablet");
                    Console.WriteLine("3. Agregar Laptop");
                    Console.WriteLine("4. Regresar al menú principal");
                    Console.Write("Elige una opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            LaBodega.AddCellphone();
                            break;
                        case 2:
                            LaBodega.AddTablet();
                            break;
                        case 3:
                            LaBodega.AddLaptop();
                            break;
                        case 4:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error encontrado: " + ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Error encontrado: " + ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
