using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    class Datos
    {
        public string articulo;

        public string Articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        public Datos()
        {
            articulo = "";       
        }

        public Datos(string art)
        {
            articulo = art;
        }

        #region //Unidad del producto y Desplegar Cantidad
        //Unidad del producto
        int[] unidadCosto = new int[2];
        int[] cantidades = new int[2];
        int[] costoProduccion = new int[2];
        double[] factorCostos = new double[2];
        int[] costoFijo = new int[2];


        public void Cantidad()
        {
            int x = 25;
            for (int o = 0; o < unidadCosto.Length; o++)
            {             
                int y = 2;
                //Cantidad de articulos
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(x, 2 + o);
                Console.Write(" - Cantidad del articulo: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(51, y + o);
                cantidades[o] = int.Parse(Console.ReadLine());
            }
        }

        public void DesplegarCantidad()
        {
            for (int o = 0; o < unidadCosto.Length; o++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30, 5 + o);

                Console.Write(cantidades[o]);
            }
        }
        //Total de unidad producidas
        public void totales()
        {
            int acumulador = 0;
            for (int o = 0; o < unidadCosto.Length; o++)
            {
                acumulador += cantidades[o];
            }
            Console.SetCursorPosition(30, 8);
            Console.Write(acumulador);
        }

        public void totalCostoProduccion()
        {
            double costoProduccion = 0;
            for (int i = 0; i < cantidades.Length; i++)
            {
                costoProduccion = cantidades[i] * (unidadCosto[i]);
            }
        }

        public void FactorDeCostos()
        {
            Random rnd = new Random();
            double numero;
            numero = rnd.Next(5, 16);

            for (int ca = 0; ca < costoFijo.Length; ca++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(58, 5 + ca);
                factorCostos[ca] = (costoFijo[ca] * (numero / 100));
                Console.Write(factorCostos[ca]);
            }

        }
        #endregion 

        #region //Costo de los Articulos

        public void CostoArticulo()
        {
            int xx = 63;
            for (int ca = 1; ca < costoFijo.Length; ca++)
            {
                int yy = 1;
                //Costo de los articulos
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(xx,1 + ca);
                Console.Write(" - Costo del articulo: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(86, yy + ca);
                costoFijo[ca] = int.Parse(Console.ReadLine());
            }
        }

        public void DesplegarArticulo()
        {
            for(int ca = 0; ca < costoFijo.Length; ca++)
            {
                Console.SetCursorPosition(82, 4 + ca);
                Console.Write(costoFijo[ca]);
            }
        }

        public void CostoDeProduccion()
        {
            for (int i = 0; i < costoProduccion.Length; i++)
            {
                Console.SetCursorPosition(100, 4 + i);
                Console.WriteLine(cantidades[i] * (costoFijo[i] + factorCostos[i]));
            }
        }

        #endregion

    }
}
