using System;
using static System.Console;

int[,,] genArray(int x, int y,int z){
    int[,,] arr = new int[x,y,z];
    Random rnd = new Random();
    for (int i = 0; i < x ; i++){
        for (int j = 0; j < y ; j++){
            for (int k = 0; k < z ; k++){
                arr[i,j,k] = rnd.Next(10,100);
            }
        }
    }
    return arr;
}

void printArray(int[,,] arr){
    for (int i = 0; i < arr.GetLength(0) ; i++){
        for (int j = 0; j < arr.GetLength(1) ; j++){
            for (int k = 0; k < arr.GetLength(2) ; k++){
                Write($"{arr[i,j,k]}({i},{j},{k}) ");
            }
        }
        WriteLine();
    }
}

int x,y,z;
int [,,] arr;
WriteLine("Введите размер массива [x,y,z]:");
x = int.Parse(ReadLine());
y = int.Parse(ReadLine());
z = int.Parse(ReadLine());

arr = genArray(x,y,z);
WriteLine("\nМассив:");
printArray(arr);