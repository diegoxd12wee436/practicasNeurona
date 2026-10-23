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

        public Matriz Sumar(Matriz otra)
        {
            //validacion no se puede sumar una M 2*2 con una 2*3 no existira la columna osea no se sumaria con null
            if (M.GetLength(0) != otra.M.GetLength(0) || M.GetLength(1) != otra.M.GetLength(1))
                throw new ArgumentException("Error los valors de Matriz A no coinciden con los de la B por ende no se pueden sumar");
                
            int filas = M.GetLength(0);
            int columnas = M.GetLength(1);

            double [,] suma = new double[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for(int j= 0; j <columnas ;j++)
                {
                    suma[i, j] = M[i, j] + otra.M[i, j];
                }    
            }
            return new Matriz(suma);

        }

        public override string ToString()
        {
            string texto = "\n";

            int filas = M.GetLength(0);
            int columnas = M.GetLength(1);


            for(int i = 0; i < filas; i++)
            {
                texto += "|";
                for(int j = 0; j < columnas; j++)
                {
                    texto += M[i,j] + " ";
                }
                texto += "|\n";
                
            }
          
            return texto;
        }


        

        
    }
}
