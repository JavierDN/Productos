using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Producto;

namespace Producto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Practica Num. 1 --------El diseño se mostrara una vez completado los datos \n");
            Datos productos = new Datos();
            string[] Productos = new string[2];
            string[] articulo = new string[2];
            int i = 1;
            //
            string acumulador = "";


            for (; i < Productos.Length; i++)
            {
                Console.WriteLine();

                for (int j = 0; j <= articulo.Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(" - Articulo: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    productos.articulo = Console.ReadLine();

                    //Acumulador - Articulo
                    acumulador = acumulador + productos.articulo + "\n";
                }
            }


            productos.Cantidad();
            
            productos.CostoArticulo();
            
            //Costo de los articulos

            Console.Clear();
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(50, 1);
            //Titulo Costo de produccion
            Console.WriteLine("COSTOS DE PRODUCCION");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(5, 3);
            Console.Write("Artículo");
            Console.SetCursorPosition(23, 3);
            Console.Write("Unidades Producidas");
            Console.SetCursorPosition(52, 3);
            Console.Write("Factor De Costos");
            Console.SetCursorPosition(77, 3);
            Console.Write("Costo Fijo");
            Console.SetCursorPosition(97, 3);
            Console.WriteLine("Costo De Produccion");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            //Desplegar Articulos
            Console.Write(acumulador);
            //Unidades producidas
            productos.DesplegarCantidad();
            //Factor de costo
            productos.FactorDeCostos();
            //Costo fijo por el usuario
            productos.DesplegarArticulo();
            Console.SetCursorPosition(5, 8);
            Console.Write("Totales: ");
            productos.totales();
            productos.CostoDeProduccion();
            Console.ReadKey();

        }


        

    }
}
