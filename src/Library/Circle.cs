//--------------------------------------------------------------------------------
// <copyright file="Circle.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Ucu.Poo.Desafios
{
    // Agrega tu clase Circle aquí.
    public class Circle
    {
        public double Radius { get; set;}

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double GetPerimeter()
        {
            return 2 * System.Math.PI * this.Radius;
        }

        public double GetArea()
        {
            return System.Math.PI * System.Math.Pow(this.Radius, 2);
        }
    }
}
