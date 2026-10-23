using System;
using System.Collections.Generic;
using System.Text;

namespace practicasNeurona.Mes1.Clases.PracticaConVectores
{
    public class Neurona
    {
      
        double[] Pesos { get; set; }
        double Sesgo { get; set; }


        public Neurona(double[] pesos, double sesgo)
        {
            Pesos = pesos;
            Sesgo = sesgo;
     
        }


        public double ProductoPunto(double[] inputs)
        {
            if (inputs.Length != Pesos.Length) throw new ArgumentException("No tinen los mismos indices");

            double productoPunto = 0 ;
            for(int i = 0 ; i < Pesos.Length; i++)
            {
                productoPunto += Pesos[i] * inputs[i];
            }

            //sumo el sesgo

            productoPunto += Sesgo;
            //aqui ya no seria solo producto pu to si no el resultado nose como se lle llama 
            productoPunto = Activaciones.Sigmoide(productoPunto);

            return productoPunto ;
        }

    }
}
