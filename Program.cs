using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string espacio = " ";
            double csto_mano_de_obra; 
            double pre_camiseta; 
            int unidades=500;
            int unidadesAumento = 500;
            int unidadesMaximas = 8000;
            double csto_total_mano_de_obra;
            double csto_fijo; 
            double csto_total;
            double ingresos; 
            double utilidades;
            string calificacion;

            Console.WriteLine("FABRICA DE CAMISETAS");
            Console.Write("Costo mano de obra: $");
            csto_mano_de_obra = double.Parse(Console.ReadLine());
            Console.Write("Precio de camiseta: $");
            pre_camiseta = double.Parse(Console.ReadLine());
            Console.Write("Costo fijo de la planta: $");
            csto_fijo = int.Parse(Console.ReadLine());

            Console.Write("\n"); //Salto de linea
            //Titulos de la tabla
            Console.Write("{0:2}", "\tUnidades");
            Console.Write("{0,25}", "Costo Total Mano Obra");
            Console.Write("{0,20}", "Costo fijo");
            Console.Write("{0,20}", "Costo Total");
            Console.Write("{0,20}", "Ingresos");
            Console.Write("{0,20}", "Utilidades");
            Console.WriteLine("{0,20}", "Calificacion");
            while ( unidades <= unidadesMaximas)
            {
                csto_total_mano_de_obra = unidades * csto_mano_de_obra;
                csto_total = csto_total_mano_de_obra + csto_fijo;
                ingresos = pre_camiseta * unidades;
                utilidades = ingresos - csto_total;

                if (utilidades > 0)
                {
                    calificacion = "Ganancia";
                }
                else if (utilidades == 0)
                {
                    calificacion = "Punto de equilibrio";
                }
                else
                {
                    calificacion = "Pérdida";
                }
                Console.Write("{0}{1}", espacio.PadRight(7, ' '), unidades.ToString("").PadLeft(7, ' '));
                Console.Write("{0}{1}", espacio.PadRight(7, ' '), csto_total_mano_de_obra.ToString("C").PadLeft(14, ' '));
                Console.Write("{0}{1}", espacio.PadRight(11, ' '), csto_fijo.ToString("C").PadLeft(14, ' '));
                Console.Write("{0}{1}", espacio.PadRight(5, ' '), csto_total.ToString("C").PadLeft(14, ' '));
                Console.Write("{0}{1}", espacio.PadRight(8, ' '), ingresos.ToString("C").PadLeft(14, ' '));
                Console.Write("{0}{1}", espacio.PadRight(6, ' '), utilidades.ToString("C").PadLeft(14, ' '));
                Console.Write("{0}{1}", espacio.PadRight(4, ' '), calificacion.PadLeft(14, ' '));
                Console.Write("{0:2}", "\n");

                unidades += unidadesAumento;
            }
            Console.ReadKey();
        }
    }
}