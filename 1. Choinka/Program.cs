﻿int counter = 11;
int workingVariable = 0;

for(int i=1; i<counter*2; i++)
{
    if(i<=counter){
        for(int j = 1; j<=i; j++){
            Console.Write($"{j} ");
        }
    }else{
        for(int j = counter; j>=i-counter+1; j--){
            Console.Write($"{j} ");
        }
    }
    Console.WriteLine("");
}
