using System;
using static System.Console;

int[,] genArray(int x, int y){
    int[,] arr = new int[x,y];
    Random rnd = new Random();
    for (int i = 0; i < x ; i++){
        for (int j = 0; j < y ; j++){
            arr[i,j] = rnd.Next(0,10);
        }
    }
    return arr;
}

int[,] sortArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0) ; i++){
        int[] tmp = new int[arr.GetLength(1)];
        for (int j = 0; j < arr.GetLength(1) ; j++){
            tmp[j] = arr[i,j];
        }

        Array.Sort(tmp);
        Array.Reverse(tmp); 

        for (int j = 0; j < arr.GetLength(1) ; j++){
            arr[i,j] = tmp[j];
        }
    }
    return arr;
}

void printArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0) ; i++){
        for (int j = 0; j < arr.GetLength(1) ; j++){
            Write($"{arr[i,j]} ");
        }
        WriteLine();
    }
}

int x,y;
int[,] arr;
WriteLine("Введите размер массива [x,y]:");
x = int.Parse(ReadLine());
y = int.Parse(ReadLine());

arr = genArray(x,y);
WriteLine("Массив:");
printArray(arr);

arr = sortArray(arr);
WriteLine("Новый массив:");
printArray(arr);
