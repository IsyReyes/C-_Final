using System;
using System.Collections.Generic;

public class LoopController(){

	public string continueOrBreak = "";

	public void loopControl(){
		Console.WriteLine("¿Quieres hacer algo más? Por favor ingresa a continuación el número correspontiende a tu decisión:");
		Console.WriteLine("1. Elegir otra tarea.");
		Console.WriteLine("2. Salir");

		continueOrBreak = Console.ReadLine();

		switch (continueOrBreak){
			case "1": 
				Options options = new Options();
				Options.printOptions();
				return;
			case "2":
				Console.WriteLine("¡Gracias por usar el Chatbot de primer semestre! Que tengas un buen día.");
				Environment.Exit(0);
				break;

		}
	}
}