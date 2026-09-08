//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.Desafios
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            Circle miCirculo = new Circle(10.0);

            Console.WriteLine($"Perímetro: {miCirculo.GetPerimeter()}");
            Console.WriteLine($"Area: {miCirculo.GetArea()}");
        }
    }
    
}
