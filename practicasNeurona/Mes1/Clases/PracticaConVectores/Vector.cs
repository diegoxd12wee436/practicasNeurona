using System;
using System.Collections.Generic;
using System.Text;

namespace practicasNeurona.Mes1.Clases.PracticaConVectores
{
    public class Vector
    {
        private double X { get; }
        private double Y { get; }
        private double Z { get; }



        public Vector( double x,double  y , double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector Sumar(Vector v)
        {
            return new Vector(X + v.X, Y + v.Y, Z + v.Z);
        }

        public double ProductoPunto( Vector v)
        {
            return X * v.X + Y * v.Y + Z * v.Z;
        }

        public override string ToString()
        {
            return $" {X} {Y} {Z}";
        }
    }
}
