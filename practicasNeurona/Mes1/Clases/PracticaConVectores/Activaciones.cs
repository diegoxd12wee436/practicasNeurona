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
    }
}
