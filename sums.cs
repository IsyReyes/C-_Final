using System;
using System.Collections.Generic;

public class Sums {

	private int num1 = 0;
	private int num2 = 0;


    public void TwoNumbers (){
		bool isNumber = false;
		
		while(!isNumber){
    		Console.WriteLine("Por favor ingresa tu primer número");
			isNumber = int.TryParse(Console.ReadLine(), out num1);
			if(!isNumber){
				Console.WriteLine("Se detectó una respuesta que no es válida, intentemos de nuevo desde el inicio, recuerda usar solo números.");
				//I'll go with a continue here to jump to next lopp's iteration in case a letter was entered.
				continue;
			}

		   	Console.WriteLine("Por favor ingresa tu segundo número");
			isNumber = int.TryParse(Console.ReadLine(), out num2);
			if(!isNumber){
				Console.WriteLine("Se detectó una respuesta que no es válida, intentemos de nuevo desde el inicio, recuerda usar solo números.");
				continue;
			}

			Console.WriteLine("Gracias, la suma de estos dos números es " + (num1 + num2));

		}
    }

}