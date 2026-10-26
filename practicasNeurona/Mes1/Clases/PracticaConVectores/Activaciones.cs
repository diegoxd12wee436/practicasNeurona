using System;
using System.Collections.Generic;
using System.Text;

namespace practicasNeurona.Mes1.Clases.PracticaConVectores
{
    //mi cajn de herramientas xd
    public static class Activaciones
    {     
              

        //La funcione sigmoide
        public static double Sigmoide(double x)
        {
            return 1 /( 1 +  Math.Exp(-x));            
        }


        //Funcion de derivada para savcar cuanto influye  el cambio de Bias

        public static double Derivada(double salida)
        {
            return salida * (1 - salida);
        }



    }
}
