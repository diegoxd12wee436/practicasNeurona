using System;
using System.Collections.Generic;
using System.Text;

namespace practicasNeurona.Mes1.Clases.PracticaConVectores
{
    public class Matriz
    {
        double[,] M { get; }

        public Matriz(double[,] matriz)
        {
            M = matriz;
        }


        //funciones

        public Matriz Sumar(double[,] Ma)
        {


            //validacion no se puede sumar una M 2*2 con una 2*3 no existira la columna osea no se sumaria con null
            if (M.GetLength(0) != Ma.GetLength(0) || M.GetLength(1) != Ma.GetLength(1)) return null;
            
            int filas = M.GetLength(0);
            int columnas = M.GetLength(1);

            double[,] suma = new double[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for(int j= 0; j <columnas ;j++)
                {
                    suma[i, j] = M[i, j] + Ma[i, j];
                }    
            }
            return new Matriz(suma);

        }


        

        
    }
}
