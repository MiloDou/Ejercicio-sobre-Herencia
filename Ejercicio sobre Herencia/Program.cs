using System.ComponentModel.Design;

namespace Herencia
{
    class Electronicos
    {
        static void main(string[] args)
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

                        }break;
                    case 2: 
                        { 
                        
                        
                        }break;
                    case 3:
                        {
                            
                        }break;
                        case 4:
                        {

                        }break;
                        case 5:
                        {
                            Exit();

                        }break;
                }




            }
            catch ( FormatException MessageError)
            {
                Console.WriteLine("Error encontrado:"+ MessageError);
            }
            catch ( OverflowException MessageError1)
            { 
                Console.WriteLine("Error encontrado:"+MessageError1);
            }
            Console.ReadKey();

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
    }
}