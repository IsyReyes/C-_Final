using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Options {

	public static void printOptions(){

		Console.WriteLine("¿Qué quieres hacer ahora mismo?");
		Console.WriteLine("1. Suma de dos números.");
		Console.WriteLine("2. Suma de tres números.");
		Console.WriteLine("3. Multicálculo para 4 números.");
		Console.WriteLine("4. Calcular la base de un triángulo.");
		Console.WriteLine("5. Calcular cuántos segundos hay en X número de días.");
		Console.WriteLine("6. Intercambiar los valores de dos variables.");

		Console.WriteLine("Salir. Escribe Salir para terminar el programa.");



		SwitchManager switchManager = new SwitchManager();
		switchManager.switchSelect();
	}
}