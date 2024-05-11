using System;
using System.Collections.Generic;

public class MatrixExercises{

    public static void ChessBoard(){
        string[] fields = ["N", "B"];

        for(int i = 0; i <= 8; i++){
            if(i % 2 == 0){
                for(int j = 0; j <=4; j++){
                    Console.Write(string.Join("", fields[0], fields[1]));
                }
            }else{
                for(int j = 0; j <=4; j++){
                    Console.Write(string.Join("", fields[1], fields[0]));
                }
            }
            Console.WriteLine();
        }
    }

    public static void MatrixBig(){
        
        int[,] karlaXimena = new int[,]{
            {1,2,3},
            {3,4,5},
            {5,6,7}
        };


}

