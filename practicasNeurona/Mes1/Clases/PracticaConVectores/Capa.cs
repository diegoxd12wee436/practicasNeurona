using System;
using System.Collections.Generic;
using System.Text;

namespace practicasNeurona.Mes1.Clases.PracticaConVectores
{
    public class Capa
    {
        public Matriz Pesos { get; set; }
        public Vector Sesgo { get; set; }

        public Capa(Matriz pesos, Vector sesgos)
        {
            if(pesos.M.GetLength(0) != sesgos.numerosVector.Length)
            {
                throw new ArgumentException("Error los valors de Matriz no coincide con el numero de sesgos");
            }

            Pesos = pesos;
            Sesgo = sesgos;
        }

        public Vector CapaOutput(Vector inputs)
        {
            return new Activaciones.Sigmoide(Sesgo.Sumar(Pesos.SalidaCapa(inputs)));
        }



    }
}
