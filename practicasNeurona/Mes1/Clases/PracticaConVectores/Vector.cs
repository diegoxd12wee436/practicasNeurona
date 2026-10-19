using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace practicasNeurona.Mes1.Clases.PracticaConVectores
{
    public class Vector
    {
        private double[] numerosVector;



        public Vector(params double[] vector)
        {
            numerosVector = vector;
            
        }

        public Vector Sumar(Vector v)
        {
            int cantVector1 = numerosVector.Length;
            int cantVector2 = v.numerosVector.Length;

            //suma variables combinacion lineal 
            double[] suma = new double[cantVector1];
            


            if(cantVector1 == cantVector2)
            {
                for(int i=0;i <cantVector1;i++)
                {
                    suma[i]= numerosVector[i] + v.numerosVector[i];
                }
                return new Vector(suma);
            }
            else
            {
                //no hace nada retornara un 1 para decir que es true osea fallo xd

                return new Vector(0); 
            }
            
        }

        public double ProductoPunto( Vector v)
        {
            //verificacion de que sean compatibles
            int cantVector1 = numerosVector.Length;
            int cantVector2 = v.numerosVector.Length;

            if (cantVector1 != cantVector2) throw new ArgumentException("Fallo vectores con distintos rangos de numeros no se pueden multiplicar"); //osea fallo

            //variables a usar
            double productoPunto = 0;

            for (int i = 0; i < cantVector1;i++)
            {
                productoPunto += v.numerosVector[i] * numerosVector[i];
            }
            
            
            return productoPunto;
        }

        public override string ToString()
        {
            string texto = "{";
            for(int i = 0; i < numerosVector.Length;i++)
            {
                texto += $" {numerosVector[i]} ";
            }
            texto += "}";
            return texto;
        }


    }
}
