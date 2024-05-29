using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Circulo:Figura // esta es una clase de figura
    {
        //usamos el contructo de la clase padre
        public Circulo(float radio)
        {
            //radio se va a leer de la caja de texto con
            //usando el boton guardar
            Lado1 = radio;
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobreescribir el compotamiento de esots
        public override float area()
        {
            return 3.1416 * Lado1 * Lado1;
            //AGREGAMOS F AL FINAL DE UN NUMERO CUANDO
            //ES UNA CONSTANTE NO DEFINA EN UNA VARIABLE
            //PREVIAMENTE, ASI EL PROGRAMA SABE QUE ES UN #
        }
        public override float perimetro()
        {
            return 3.1416 * 2 * Lado1;
        }
       
    }
}
