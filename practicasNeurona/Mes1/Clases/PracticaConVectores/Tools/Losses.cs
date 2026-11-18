using System;
using System.Collections.Generic;
using System.Text;

namespace practicasNeurona.Mes1.Clases.PracticaConVectores.Tools
{
    public static class Losses
    {
        //backpropagation
        public static (List<Matriz> GradientPesos, List<Vector> GradientSesgos) BackPropagation(List<Capa> capas, Vector inputs, Vector objetivo)
        {
            //variables a retornar los ocntenedores del los gradientes por capa

            List<Matriz> Gpesos = new List<Matriz>();
            List<Vector> Gsesgos = new List<Vector>();

            //guarda las salidas de cada capa

            Vector salidasCapas = ForwardPropagation(capas, inputs);


            
           

            return (Gpesos,Gsesgos);
        }

        

        //propagacion adelante

        public static Vector ForwardPropagation(List<Capa> capas, Vector inputs)
        {
            Vector salida = inputs;
            foreach (Capa c in capas)
            {
                salida = c.CapaOutput(salida);
            }
            return salida;
        }
        //
        public static double CalcularLoss (List<Capa> capas, Vector inputs,Vector objetivo)
        {
            //propagacion hacia adelante

            Vector salida = ForwardPropagation(capas, inputs);
           
            //calcular el loss
            double loss = LossMSE(salida, objetivo);
            return loss;
        }


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



        //calcular derivada de todos los weigth de todas las capas

        public static List<Matriz> CalcularGradientesPesos(List<Capa> capas, Vector input , Vector Objetivo , double h  = 0.001)
        {

            //el loss original 
            double lossBase = Losses.CalcularLoss(capas, input, Objetivo);

            List<Matriz> Gradients = new List<Matriz>();

            //sacar los valores originales de los pesos y del loss
            //recorres las capas y guardas los pesos originales en una lista de matrices

            foreach(Capa c in capas)
            {
                int filas  = c.Pesos.M.GetLength(0); //equivaldria a una neurona cada fila
                int columnas = c.Pesos.M.GetLength(1);


                double[,] GradientesCapa = new double[filas, columnas];




                for (int i = 0; i < filas; i++)
                {
                    for(int j = 0; j < columnas; j++)
                    {
                        //comento porque si no la canteo 
                        //aqui guardo el valor actual del peso (w)
                        double actualWeight = c.Pesos.M[i, j];


                        //lo modifico como un temp
                        c.Pesos.M[i, j] = actualWeight + h;

                        double nuevoLoss = CalcularLoss(capas, input, Objetivo);

                        //lo regreso a la normalidad
                        c.Pesos.M[i, j] = actualWeight;

                        //saco la derivada (gradientes) 
                        GradientesCapa[i, j] = (nuevoLoss - lossBase) / h;                    
                    }

                }
                Gradients.Add(new Matriz(GradientesCapa));
            }            
            return Gradients;


        }

        //actualizar pesos
        public static void ActualizarPesos(List<Capa>  capas , List<Matriz> gradientes , double LearningRate)
        {
            if (capas.Count != gradientes.Count)
                throw new ArgumentException("La cantidad de capas no coinside con la cantidad de gradientes (osea su conjunto de derviads parcial no es la correcta)");

            //recorrer cada capa
            for(int c = 0; c < capas.Count; c++)
            {
                int rows = capas[c].Pesos.M.GetLength(0);
                int columns = capas[c].Pesos.M.GetLength(1);

                for(int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < columns; j++)
                    {
                        capas[c].Pesos.M[i, j] -= gradientes[c].M[i, j] * LearningRate;
                    }
                }
            }
        }



    }
}
