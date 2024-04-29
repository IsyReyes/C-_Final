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
		Console.WriteLine("7. Buscar el ángulo faltante de un triángulo.");
		Console.WriteLine("8. Convertir grados de Celsius a Farenheit.");
		Console.WriteLine("9. Operación con variables predefinidas, dale dinero a Juan.");
		Console.WriteLine("10. Calcular tu edad hasta el año 2030");
		Console.WriteLine("11. Realizar la ecuación cuadrática con coeficientes predefinidos.");
		Console.WriteLine("12. Obtener tu sueldo por hora.");


		Console.WriteLine("Salir. Escribe Salir para terminar el programa.");



		SwitchManager switchManager = new SwitchManager();
		switchManager.switchSelect();
	}
}