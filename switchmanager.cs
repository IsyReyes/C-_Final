using System;
using System.Collections.Generic;

public class SwitchManager{


private string choice = " ";



	public void switchSelect(){


    choice = Console.ReadLine();

	if(!choice.Equals("Salir", StringComparison.OrdinalIgnoreCase)){
    Console.WriteLine("Excelente, has seleccionado la opción número " + choice + ", estaré encantada de ayudarte a resolver esta tarea.");
	} else{
		Console.WriteLine("¡Gracias por usar el Chatbot de primer semestre! Que tengas un buen día.");
		Environment.Exit(0);
	}


	BasicArithmetic basicArithmetic = new BasicArithmetic();
	LoopController loopController = new LoopController();

    switch (choice) {
		case "1": 
		basicArithmetic.TwoNumbers();
		break;
		case "2":
		basicArithmetic.ThreeNumbers();
		break;
		case "3":
		basicArithmetic.multiCalculate();
		break;
		case "4":
		BasicArithmetic.TriangleArea();
		break;
		case "5":
		BasicArithmetic.SecondsInADay();
		break;
		case "6":
		VariableExchange.ExchangeVariable();
		break;
		case "7":
		ReturnMissing.getAngles();
		break;
		case "8":
		Degrees.ConvertDegrees();
		break;
		case "9":
		ReturnMissing.MissingMoney();
		break;
		case "10":
		calculateAge.AgeInFuture();
		break;
		case "Salir":
		break;
		default:
    	Console.WriteLine("Opción no reconocida, intenta de nuevo.");
    	break;
		
    }
    loopController.loopControl();

	}
}