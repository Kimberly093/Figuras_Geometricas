using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    abstract class Figura //CLASE PADRE
    {
        /* CLASE QUE PERMITE EL INGRESO
         * DE UN LADO, PARA PODER CREAR UNA 
         * NUEVA FIGURA GEOMETRICA
         * RECUERDA QUE UNA FIGURA PARA
         * EXISTIR REQUIERE MINIMO UN LADO
         ESTA CLASE ES UN MOLDE*/

        /*DECLARAMOS LAS VARIABLES QUE
         * SE VAN A PASAR A LAS CLASES HIJOS
         * NOS SERVIRAN PARA GUARDAR EN CAJA
         * DE MEMORIA EL VALOR DEL PRIMER LADO
         */

        // LA VARIABLE SERA PRIVADA
        private float lado1; // permite decimales

        //creamos atributos o propiedades
        //definimos el constructor

        public float Lado1
        {
            /* METODO O MODIFICADOR
             * PARA PONER EL
             * VALOR (#) EN LA CAJA DE 
             * MEMORIA*/
            set//obtener valor
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado1 = 0;//manda el valor a 0
                } //NO EXSITEN LADOS NEGATIVOS
                else
                {
                    lado1 = value;
                    //value es el valor del textobox
                }
            }
            get //obtener el valor
            {
                return lado1; // regresa o cacha el valor de la variable lado1
            }
        }
            //defino metodos, funciones, operaciones de la clase padre que tambien van a tener los hijos
            //metodos de tipo publico para que todos los usen
            //metodos abstractos van vacion ya que cada hijo definira sus operaciones

        public abstract float area();
        public abstract float perimetro();
        public abstract float volumen();
    

    }
}

