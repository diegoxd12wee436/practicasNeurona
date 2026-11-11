using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics;
using practicasNeurona.Mes1.Clases.PracticaConVectores;


//double[] pesos =
//{
//    5,-3
//};

//double[] inputs = { 1, 1 };


//for(int i = -10; i <= 10; i += 2)
//{
//    Neurona n = new Neurona(pesos, i);
//    double result = n.Salida(inputs);

//    Console.WriteLine($"Iteracion {i}");
//    Console.WriteLine("Salida: " + result);    
//    Console.WriteLine("Sigmoide + derivada : " + Activaciones.Derivada(result));

//}

Vector vprueba = new Vector(1, 2, 3, 4, 5);

Console.WriteLine(vprueba.numerosVector.Length);



Matriz mPrueba = new Matriz(new double[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } });
Console.WriteLine(mPrueba.SalidaCapa(vprueba));