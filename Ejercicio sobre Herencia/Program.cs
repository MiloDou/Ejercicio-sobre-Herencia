using Ejercicio_sobre_Herencia;
using System.ComponentModel.Design;

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
                    int opcion;
                    Console.Write("Elige una opcion: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            {
                                MenuAdd();
                            }
                            break;
                        case 2:
                            {
                                LaBodega.ShowProduct();
                            }
                            break;
                        case 3:
                            {
                                LaBodega.SearchProduct();
                            }
                            break;
                        case 4:
                            {
                                Exit();
                            }
                            break;

                    }

                }
                catch (FormatException MessageError)
                {
                    Console.WriteLine("Error encontrado:" + MessageError);
                }
                catch (OverflowException MessageError1)
                {
                    Console.WriteLine("Error encontrado:" + MessageError1);
                }
                Console.ReadKey();

            } 
        }
        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("             MENU");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Mostar Producto");
            Console.WriteLine("3. Buscar Producto");
            Console.WriteLine("4. Salir");
        }
        static void Exit()
        {
            Console.WriteLine("Ciao user...");
            Console.WriteLine("Presiona ENTER para salir");
        }
        static void MenuAdd()
        {
            Bodega LaBodega = new Bodega();
            {
                while (true)
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
                        Console.Write("Elige una opcion: ");
                        int option1 = Convert.ToInt32(Console.ReadLine());
                        switch (option1)
                        {
                            case 1:
                                {
                                    LaBodega.AddCellphone();
                                }
                                break;
                            case 2:
                                {
                                    LaBodega.AddTablet();
                                }
                                break;
                            case 3:
                                {
                                    LaBodega.AddLaptop();
                                }
                                break;

                        }
                    }
                    catch (FormatException MessageError)
                    {
                        Console.WriteLine("Error encontrado:" + MessageError);
                    }
                    catch (OverflowException MessageError1)
                    {
                        Console.WriteLine("Error encontrado:" + MessageError1);
                    }
                    Console.ReadKey();
                } 
            }
        }
    }
}