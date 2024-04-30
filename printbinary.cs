using System;
using System.Collections.Generic;

public class Binary{

    public static void PrintBinary(){
        Console.WriteLine("Por favor, ingresa un número decimal para convertirlo a binario:");
        int numeroDecimal = Convert.ToInt32(Console.ReadLine());  // Lee el número decimal del usuario

        string numeroBinario = Convert.ToString(numeroDecimal, 2);  // Convierte el número decimal a binario
        Console.WriteLine($"El número {numeroDecimal} en binario es: {numeroBinario}");  // Imprime el número en binario
    }
}