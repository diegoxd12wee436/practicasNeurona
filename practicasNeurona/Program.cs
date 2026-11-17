using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics;
using practicasNeurona.Mes1.Clases.PracticaConVectores;
using practicasNeurona.Mes1.Clases.PracticaConVectores.Tools;



var inputs = new Vector(3, 4, 2);
Console.WriteLine("Inputs cantidad: " + inputs.numerosVector.Length);

Matriz NeuronasCapa1 = Matriz.CrearMatriz(4, 3);
Vector SesgosCapa1 = Vector.CrearSesgos(4);

Capa capa1 = new Capa(NeuronasCapa1, SesgosCapa1);

Vector SalidaCapa1 = capa1.CapaOutput(inputs);

Console.WriteLine("Salida Capa 1: " + SalidaCapa1);

//capa 2
Matriz NeuronasCapa2 = Matriz.CrearMatriz(3, 4);
Vector SesgosCapa2 = Vector.CrearSesgos(3);

Capa capa2 = new Capa(NeuronasCapa2, SesgosCapa2);

Vector SalidaCapa2 = capa2.CapaOutput(SalidaCapa1);


Console.WriteLine("Salida Capa 2: " + SalidaCapa2);


//capa Salida Final
Matriz NeuronasCapa3 = Matriz.CrearMatriz(4, 3);
Vector SesgosCapa3 = Vector.CrearSesgos(4);

Capa capa3 = new Capa(NeuronasCapa3, SesgosCapa3);

Vector SalidaFinal = capa3.CapaOutput(SalidaCapa2);


Console.WriteLine("Salida Capa 3 final : " + SalidaFinal);



Console.WriteLine("ERROR LOSS DE LA SALIDA MSE: " + Losses.LossMSE(SalidaFinal, new Vector(0, 0, 0, 0)));


Console.WriteLine("erorr de prueba loss : " + Losses.LossMSE(new Vector(0.3, 0.8), new Vector(0, 0)));


var capas = new List<Capa> { capa1, capa2, capa3 };
Console.WriteLine(Losses.CalcularLoss(capas, inputs, new Vector(0, 0, 0, 0)));
