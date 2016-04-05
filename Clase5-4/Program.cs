using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5_4
{
    class Dato
    {
       public int numero;
    

    }

    class Program
    {
        static void Main(string[] args)
        {
            float Resultado;
   
            Console.WriteLine();//Recibe distintos parametros y todo lo transforma en string.
            Factura FacturaUno = new Factura(20, 5f);
            Factura FacturaDos = new Factura(5f, 20);

            /*  ESTAS LINEAS DE CODIGO NO FUNCIONAN!!!
             * 
                Resultado = FacturaUno + FacturaDos;

                if (FacturaUno == FacturaDos)
                {
                    Console.WriteLine("Tienen el mismo importe");
                }
             *   ESTAS LINEAS DE CODIGO NO FUNCIONAN!!!
             */

            Dato a = new Dato();
            Dato b = new Dato();

            a.numero = 22;
            b.numero = 30;

            a = b;
            a.numero = 10;






        }
    }
}
