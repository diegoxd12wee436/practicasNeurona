using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics;
using practicasNeurona.Mes1.Clases.PracticaConVectores;

/////prueba de producto punto
/////

////variables
//List<double> entradas = new List<double> { 1, 1 };
//List<double> pesos = new List<double> { 5, -3 };





//CalcularProductoDot(entradas,pesos);
//void CalcularProductoDot(List<double> v1 , List<double> v2)
//{
//    List<double> resultMulti = new();
//    double ProductoPunto = 0;

//    if (v1.Count == v2.Count)
//    {
//        for (int i = 0; i < v1.Count; i++)
//        {
//            resultMulti.Add(v1[i] * v2[i]);
//        }

//        foreach (var r in resultMulti)
//        {
//            ProductoPunto += r;
//        }


//    }
//    else
//    {
//        //ssacar cual es mayor y ppnerle  el peso de 1 si no tiene suficiente
//        if (v1.Count < v2.Count)
//        {
//            int restante = Math.Abs(v1.Count - v2.Count);

//            for (int i = 0; i < v2.Count; i++)
//            {
//                if (i >= v1.Count )
//                {
//                    v1.Add(1); //el peso sera 1 por default asi que para todsas las veces que sea mayor pues se cumple xd

//                }

//                resultMulti.Add(v1[i] * v2[i]);

//            }
//            foreach (var r in resultMulti)
//            {
//                ProductoPunto += r;

//            }

//        }
//        else
//        {           

//            for (int i = 0; i < v1.Count; i++)
//            {
//                if (i >= v2.Count )
//                {
//                    v2.Add(1); //el peso sera 1 por default asi que para todsas las veces que sea mayor pues se cumple xd

//                }

//                resultMulti.Add(v1[i] * v2[i]);

//            }
//            foreach (var r in resultMulti)
//            {
//                ProductoPunto += r;

//            }

//        }



//    }
//    Console.WriteLine($"La suma de producto punto es de : {ProductoPunto}");
//}

/// <summary> CLASE DE VECTORES PRUEBA DIA 3</summary>
/// 

Vector v1 = new Vector(1, 6, 3);
Vector v2 = new Vector(10, 5, 6);

double num = v1.ProductoPunto(v2);
Vector vsum = v1.Sumar(v2);
Console.Write("producto punto es  :" + num +" y la suma de ambos da " + vsum.ToString());


//
Console.WriteLine("\n\n\n");
//martreiz 2x2
double[,] m1 =
{
    {1,2 },
    {3,4 }
};

double[,] m2 =
{
    {5,6},
    {8,9}
};

Matriz matrizA = new Matriz(m1);
Matriz matrizB = new Matriz(m2);



string text = matrizA.ToString() + " " + matrizB.ToString()+ " = " + matrizA.Sumar(m2);
Console.WriteLine(text);





