using System;
using System.Collections.Generic;

public class SwitchManager{


private string choice = " ";

LoopController loopController = new LoopController();

public void switchSelect(){

// main method for starting the conversation. Will move rest of text later to include the conversational loop inside a new method
// and not having to ask for the name again every time we come back here.
    choice = Console.ReadLine();


    Console.WriteLine("Excelente, has seleccionado la opción número " + choice + ", estaré encantada de ayudarte a resolver esta tarea.");

BasicArithmetic basicArithmetic = new BasicArithmetic();

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
    }
    loopController.loopControl();

  }
}