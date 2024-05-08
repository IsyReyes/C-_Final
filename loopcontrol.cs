using System;
using System.Collections.Generic;

public class LoopController(){

	public void loopControl(){
		bool continueLoop = true;
			while (continueLoop){
				Console.WriteLine("¿Quieres hacer algo más? Por favor ingresa a continuación el número correspontiende a tu decisión:");
				Console.WriteLine("1. Elegir otra tarea.");
				Console.WriteLine("2. Salir");

				int decision = ErrorHandler.SafeParseInt("Introduce tu elección:");


				switch (decision){
					case 1: 
						Options options = new Options();
						Options.printOptions();
						break;
					case 2:
						Console.WriteLine("¡Gracias por usar el Chatbot de primer semestre! Que tengas un buen día.");
						Environment.Exit(0);
						break;
					default:
					Console.WriteLine("Por favor introduce un número válido (1 o 2).");
                	break;
			}
		}
	}
}