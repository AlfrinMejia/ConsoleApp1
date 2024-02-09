using System;
using System.Collections.Generic;
using System.Collections; //la agregamos para poder utilizar el ArrayList
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;
namespace CAInventario
{
    class Program
    {
        static void Main(string[] args)
        {   //Creando una instancia (objeto) de la clase Producto
            int menuopcion;
            Producto producto = new Producto();
            ArrayList AProducto = new ArrayList();
            AProducto.Add(new Producto(1, 1, 100, "Prueba", 1000, true));
            do
            {
                Console.Clear();
                Cuadro(1, 80, 1, 6);                                //Invocacion al metodo Cuadro con valores para sus parametros
                Titulos();                                      //Invocacion al metodo que muestra los titulos
                Menu();                                         //Invocacion al metodo que muestra las opciones del menu
                menuopcion = MenuChoice();                      //Invocacion al metodo para capturar la opcion elegida por el usuario
                DoChoice(menuopcion, AProducto, producto);      //Llamada al metodo para ejecutar la función dada
                                                                // a la opción elegida por el usuario
                Console.ReadKey();
            } while (menuopcion != 0);
        }// creacion del cuadro
        public static void Cuadro(int x1, int x2, int y1, int y2)
        {
            //Creamos las lineas horizontales
            for (int x = x1; x <= x2; x++)
            {
                Console.SetCursorPosition(x, y1); Console.Write("═"); //Alt+205
                Console.SetCursorPosition(x, y2); Console.Write("═"); //Alt+ 205
            }
            //Creamos las lineas verticales
            for (int y = y1;  y <= y2; y++)
            {
                Console.SetCursorPosition(x1, y); Console.Write("║"); //Alt+186
                Console.SetCursorPosition(x2, y); Console.Write("║"); //Alt+186
            }
            Console.SetCursorPosition(x1, y1); Console.Write("╔"); //Alt+201
            Console.SetCursorPosition(x2, y1); Console.Write("╗"); //Alt+187
            Console.SetCursorPosition(x1, y2); Console.Write("╚"); //Alt+200
            Console.SetCursorPosition(x2, y2); Console.Write("╝"); //Alt+188
        }
        public static void Titulos()
        {
            string t1 = "ISC, S.R.L.",
            t2 = "La excelencia en servicio",
            t3 = "Sistema de inventario",
            t5 = "Alfrin Mejia 2022-0927" ,
            t6 = "Robert Adonis",
            t4 = "Menu Principal";
            Console.SetCursorPosition((80 - t1.Length) / 2, 2); Console.Write(t1);
            Console.SetCursorPosition((80 - t2.Length) / 2, 3); Console.Write(t2);
            Console.SetCursorPosition((80 - t3.Length) / 2, 4); Console.Write(t3);
            Console.SetCursorPosition((80 - t4.Length) / 2, 5); Console.Write(t4);
            Console.SetCursorPosition((80 - t4.Length) / 2, 6); Console.Write(t5);
            Console.SetCursorPosition((80 - t4.Length) / 2, 7); Console.Write(t6);
        }
        public static void Menu()
        {
            Console.SetCursorPosition(15, 8); Console.Write("1- Registrar Categoria de productos");
            Console.SetCursorPosition(15, 9); Console.Write("2- Registrar productos");
            Console.SetCursorPosition(15, 10); Console.Write("3- Aumentar inventario");
            Console.SetCursorPosition(15, 11); Console.Write("4- Reducir inventario");
            Console.SetCursorPosition(15, 12); Console.Write("5- Consultar inventario");
            Console.SetCursorPosition(15, 13); Console.Write("0- Salir");
        }
        public static int MenuChoice()
        {
            int op = 1;
            do
            {
                try
                {
                    Console.SetCursorPosition(15, 15); Console.Write("Su opcion...: ");
                    op = Convert.ToInt32(Console.ReadLine());
                    if (op < 0 || op > 5)
                    {
                        Console.SetCursorPosition(20, 24); Console.WriteLine("Ha elegido una opción No Válida");
                    }
                }
                catch (Exception e)
                {
                    Console.SetCursorPosition(20, 24); Console.WriteLine(e.Message);
                }

            } while (op < 0 || op > 5);
            return op;
        }
        public static void DoChoice(int opcion, ArrayList AProducto, Producto producto)
        {
            switch (opcion)
            {
                case 1:
                    //RegistrarCategoria();
                    Console.SetCursorPosition(20, 24); Console.Write("En construccion");
                    break;
                case 2:
                    RegistrarProducto(AProducto, producto);
                    //Console.SetCursorPosition(20, 24); Console.Write("En construccion");
                    break;
                case 3:
                    //AumentarInventario();
                    Console.SetCursorPosition(20, 24); Console.Write("En construccion");
                    break;
                case 4:
                    //ReducirInventario();
                    Console.SetCursorPosition(20, 24); Console.Write("En construccion");
                    break;
                case 5:
                    ConsultarInventario(AProducto, producto);
                    //Console.SetCursorPosition(20, 24); Console.Write("En construccion");
                    break;
            }
        }//fin del metodo DoChoice
        public static void RegistrarProducto(ArrayList AProd, Producto prod)
        {
            int vidprod = 0, vexistencia = 0, vidcategoria = 0;
            double vprecio = 0.00;
            string vnombre = "";
            bool vactivo = true;
            limpia(1, 79, 8, 20); //invocacion al metodo para limpiar parte de la pantalla
            Console.SetCursorPosition(28, 08); Console.Write("REGISTRO DE PRODUCTOS");
            Console.SetCursorPosition(20, 10); Console.Write("ID Producto....: ");
            vidprod = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(20, 11); Console.Write("ID Categoria...: ");
            vidcategoria = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(20, 12); Console.Write("Nombre.........: ");
            vnombre = Console.ReadLine();
            Console.SetCursorPosition(20, 13); Console.Write("Precio ........: ");
            vprecio = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(20, 14); Console.Write("Existencia.....: ");
            vexistencia = Convert.ToInt32(Console.ReadLine());

            //Agrego el nuevo objeto al final del ArrayList
            AProd.Add(new Producto(vidprod, vidcategoria, vexistencia, vnombre, vprecio, vactivo));
            Console.SetCursorPosition(20, 24); Console.WriteLine("Producto registrado satisfactoriamente!");
            Console.ReadKey();
        }//fin del metodo RegistrarProducto
        public static void ConsultarInventario(ArrayList Aprod, Producto prod)
        {
            int fila = 11;
            limpia(1, 79, 8, 20); //invocacion al metodo para limpiar parte de la pantalla
            Console.SetCursorPosition(28, 08); Console.Write("PRODUCTOS EN EL INVENTARIO");
            Console.BackgroundColor = ConsoleColor.Gray; //Le coloco un color de fondo Gris a los titulos
            Console.ForegroundColor = ConsoleColor.Black; //Coloco el color negro al texto para destacarlo
            Console.SetCursorPosition(1, 10); Console.Write(" IDProducto|IDCategoria| Nombre del Producto| Existencia | Precio | Estado ");

            Console.ResetColor(); //Vuelvo a los colores por defecto
            foreach (Producto p in Aprod)
            {
                Console.SetCursorPosition(5, fila); Console.Write(p.getIDProducto());
                Console.SetCursorPosition(18, fila); Console.Write(p.getIDCategoria());
                Console.SetCursorPosition(25, fila); Console.Write(p.getNombre());
                Console.SetCursorPosition(55, fila); Console.Write(p.getExistencia());
                Console.SetCursorPosition(65, fila); Console.Write(p.getPrecio());
                Console.SetCursorPosition(73, fila); Console.Write((p.getActivo()) ? "Activo" : "Inactivo"); //operador ternariofila ++;
                fila++;
            
            }

            Console.ReadKey();
        }//Fin metodo ConsultarInventario
        public static void limpia(int x1, int x2, int y1, int y2)
        {
            for (int x = x1; x <= x2; x++)
                for (int y = y1; y <= y2; y++)
                {
                    Console.SetCursorPosition(x, y); Console.Write(" ");
                }
        }//fin del método Limpia
    }//fin de la clase Program
}