using System;
using System.Collections.Generic;

public class Quadratic
{
    public static void QuadraticEquation()
    {
        int a = 1;
        int b = 3;
        int c = 2;
        double x1, x2;
        double discriminant = Math.Pow(b, 2) - 4 * a * c;

        if (discriminant >= 0)
        {
            // Calcula las raíces solo si el discriminante es no negativo
            x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Los valores son: X1 = {0}, X2 = {1}", x1, x2);
        }
        else
        {
            // Si el discriminante es negativo, no hay raíces reales
            Console.WriteLine("No hay soluciones reales porque el discriminante es negativo.");
        }
    }
}