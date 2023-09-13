using System;
using static System.Console;

int[,] genArray(int size){
    int [,] arr = new int[size,size];
    int counter = 1,i = 0,j = 0;
    while (counter <= 16)
    {
        switch (counter)
        {
            case <=4:   
                    arr[i,j] = counter;
                    counter++;
                    if (j!= size-1){
                        j++;
                    }
                    
                    break;
            case <=7:
                    if (i!= size-1){
                        i++;
                    }
                    arr[i,j] = counter;
                    counter++;
                      break; 
            case <=10:
                    if (j!= 0){
                        j--;
                    }
                    arr[i,j] = counter;
                    counter++;
                    break;
            case <=12:
                    if (i!= 1){
                        i--;
                    } 
                    arr[i,j] = counter;
                    counter++;
                    break; 
            case <=14:
                    if (j!= size-2){
                        j++;
                    }
                    arr[i,j] = counter;
                    counter++;
                    break; 
            case <= 16:
                    if (i == 1){
                        i++;
                    }else{
                        j--;
                    }
                    arr[i,j] = counter;
                    counter++;
                    break; 
            default:
            counter++;
            break;
        }
    }
    return arr;
}

void printArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0) ; i++){
        for (int j = 0; j < arr.GetLength(1) ; j++){
            Write($"{arr[i,j]}\t");
        }
        WriteLine();
    }
}

int size = 4;
int [,] arr;

arr = genArray(size);
WriteLine("\nМассив:");
printArray(arr);