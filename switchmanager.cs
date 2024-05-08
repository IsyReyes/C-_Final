using System;
using System.Collections.Generic;

public class SwitchManager{



	int selection = ErrorHandler.SafeParseInt("Selección:");


	public void switchSelect(){


	if(selection != 0){
    Console.WriteLine("Excelente, has seleccionado la opción número " + selection + ", estaré encantada de ayudarte a resolver esta tarea.");
	} else{
		Console.WriteLine("¡Gracias por usar el Chatbot de primer semestre! Que tengas un buen día.");
		Environment.Exit(0);
	}


	LoopController loopController = new LoopController();

    switch (selection) {
		case 1: 
			BasicArithmetic.TwoNumbers();
			break;
		case 2:
			BasicArithmetic.ThreeNumbers();
			break;
		case 3:
			BasicArithmetic.multiCalculate();
			break;
		case 4:
			BasicArithmetic.TriangleArea();
			break;
		case 5:
			BasicArithmetic.SecondsInADay();
			break;
		case 6:
			VariableExchange.ExchangeVariable();
			break;
		case 7:
			ReturnMissing.getAngles();
			break;
		case 8:
			Degrees.ConvertDegrees();
			break;
		case 9:
			ReturnMissing.MissingMoney();
			break;
		case 10:
			calculateAge.AgeInFuture();
			break;
		case 11:
			Quadratic.QuadraticEquation();
			break;
		case 12:
			EmployeeCalculator.CalculateHourlyWage();
			break;
		case 13:
			TonsCalculator.TonsRate();
			break;
		case 14:
			PassOrFail.AcademicCheck();
			break;
		case 15:
			Promos.PrintDiscount();
			break;
		case 16:
			Promos.ShirtsTotal();
			break;
		case 17:
			Promos.SupermarketDiscounts();
			break;
		case 18:
			Loops.PositivesOnly();
			break;
		case 19:
			Loops.Multiply();
			break;
		case 20:
			Loops.GetFactorial();
			break;
		case 21:
			Loops.GetHighest();
			break;
		case 22:
			Loops.EvenOrOdd();
			break;
		case 23:
			Loops.Fibonacci();
			break;
		case 24:
			Loops.BelongsToFibonacci();
			break;
		case 25:
			CoolStair.LeftSideStair();
			break;
		case 26:
			SequenceOfActions.SequenceUntil23();
			break;
		case 27:
			SequenceOfActions.SequenceAddEvensDoWhile();
			break;
		case 28:
			SequenceOfActions.InvertNumber();
			break;
		case 29:
			SequenceOfActions.FibonacciUntil10k();
			break;
		case 30:
			Binary.PrintBinary();
			break;
		case 31:
			Arrays.ArrayEvensAndOdds();
			break;
		case 32:
			Arrays.ShiftArrays();
			break;
		case 33:
			Arrays.ArrayComparison();
			break;
		case 34:
			Arrays.ArrayMaxMin();
			break;
		case 35:
			Arrays.ArrayABC();
			break;
		case 36:
			Arrays.ArrayAverage();
			break;
		case 0:
			break;
		default:
    		Console.WriteLine("Opción no reconocida, intenta de nuevo.");
    		break;
    }
    loopController.loopControl();

	}
}