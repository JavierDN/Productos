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
        int[] unidadCosto = new int[10];
        int[] cantidades = new int[10];
        int[] costoProduccion = new int[10];
        double[] factorCostos = new double[10];
        int[] costoFijo = new int[10];


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
                Console.SetCursorPosition(30, 7 + o);
                acumulador += cantidades[o];
            }
            
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
            for (int ca = 0; ca < costoFijo.Length; ca++)
            {
                int yy = 2;
                //Costo de los articulos
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(xx,2 + ca);
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
                Console.SetCursorPosition(82, 5 + ca);
                Console.Write(costoFijo[ca]);
            }
        }

        public double granTotal = 0;

        public void CostoDeProduccion()
        {
            for (int i = 0; i < costoProduccion.Length; i++)
            {
                Console.SetCursorPosition(101, 5 + i);
                granTotal += cantidades[i] * (costoFijo[i] + factorCostos[i]);
                Console.WriteLine(cantidades[i] * (costoFijo[i] + factorCostos[i]));
            }
        }

        #endregion

    }
}
