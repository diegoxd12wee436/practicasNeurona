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


        public double Salida(double[] inputs)
        {
            if (inputs.Length != Pesos.Length) throw new ArgumentException("No tinen los mismos indices");

            double salidaNeurona = 0 ;
            for(int i = 0 ; i < Pesos.Length; i++)
            {
                salidaNeurona += Pesos[i] * inputs[i];
            }

            //sumo el sesgo

            salidaNeurona += Sesgo;
            //aqui ya no seria solo producto pu to si no el resultado nose como se lle llama 
            salidaNeurona = Activaciones.Sigmoide(salidaNeurona);

            return salidaNeurona ;
        }

    }
}
