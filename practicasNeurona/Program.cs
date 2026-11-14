using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics;
using practicasNeurona.Mes1.Clases.PracticaConVectores;


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



