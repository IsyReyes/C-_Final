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
		Console.WriteLine("13. Calcular costo por traslado de toneladas.");
		Console.WriteLine("14. Saber si estás aprobado o reprobado.");
        Console.WriteLine("15. Calcular descuento por artículo.");
        Console.WriteLine("16. Calcular total a pagar por camisas.");
        Console.WriteLine("17. Calcular descuento en supermercado.");
		Console.WriteLine("18. Imprimir números solo si son positivos con un loop.");
		Console.WriteLine("19. Obtén la tabla de multiplicar de un número.");
		Console.WriteLine("20. Obtener el factorial de un número.");
		Console.WriteLine("21. Imprimir el número más grande entre varios inputs.");
		Console.WriteLine("22. Imprimir la suma de números pares en impares entre el 300 y 555.");
		Console.WriteLine("23. Imprimir los primeros 30 números en la serie de Fibonacci.");
		Console.WriteLine("24. Verificar si un número pertenece a la serie de Fibonacci.");
		Console.WriteLine("25. Imprimir una escalerita perrona con una altura que tú elijas!!");
		Console.WriteLine("26. Imprimir una secuencia de números hasta el 23.");
		Console.WriteLine("27. Sumar todos los número pares entre el 1 y el 100.");
		Console.WriteLine("28. Inivierte un número positivo.");
		Console.WriteLine("29. Sumar los números de Fibonacci entre el 100 y el 10000.");






		Console.WriteLine("Salir. Escribe Salir para terminar el programa.");

		SwitchManager switchManager = new SwitchManager();
		switchManager.switchSelect();
	}
}