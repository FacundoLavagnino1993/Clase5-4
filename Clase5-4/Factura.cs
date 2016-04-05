using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5_4
{
    class Factura
    {
        //Sobrecarga de metodos:
            // Crear metodos de igual nombre que reciban distintos tipos de parametros.
            
        DateTime fecha;
        public int numero;
        public float importe;


        public Factura()
        {
            this.fecha = DateTime.Now;//Se obtiene la fecha actual.
        }

        public Factura(int numero, float importe):this()// Con este this llamamos al constructor de arriba iniciando la fecha en los demas constructores.
        {
            
            this.numero = numero;
            this.importe = importe;
        }

        // Se cambia el orden de los parametros.

        public Factura(float importe, int numero):this(numero,importe)//Se utiliza el this, se le pasan los parametros del constructor de arriba 
        {                                                             // Con los mismos nombres de los parametros que recibe el constructor que invoca al this.
            
            //this.importe = importe;  Se omiten las lineas comentadas para no repetir lineas.
            //this.numero = numero;
        }


        //
        public Factura(DateTime fecha, int numero)
        {
            this.fecha = fecha;
            this.numero = numero;
        }

        public Factura(int numero, DateTime fecha)
            : this(fecha, numero)
        { }

        public Factura(float importe, DateTime fecha)
        {
            this.importe = importe;
            this.fecha = fecha;
        }

        public Factura(DateTime fecha, float importe)
            : this(importe, fecha)
        { }


    }
}
