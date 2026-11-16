using System;
using System.Collections.Generic;
using System.Text;

namespace practicasNeurona.Mes1.Clases.PracticaConVectores.Tools
{
    public static class Losses
    {




        //loss de error cuadratico medio
        public static double LossMSE(Vector Salida , Vector Objetivo)
        {
            if(Salida.numerosVector.Length != Objetivo.numerosVector.Length)
            {
                throw new ArgumentException("Error los valors de Salida no coinciden con los de Objetivo por ende no se puede calcular el loss");
            }

            int cantVector = Salida.numerosVector.Length;

            double loss = 0;

            for (int i = 0; i < cantVector; i++)
            {
                
                double diff = Salida.numerosVector[i] - Objetivo.numerosVector[i];
                loss += diff * diff;
            }

            return loss / cantVector;

        }




    }
}
