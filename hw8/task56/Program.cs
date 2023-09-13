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

void printArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0) ; i++){
        for (int j = 0; j < arr.GetLength(1) ; j++){
            Write($"{arr[i,j]} ");
        }
        WriteLine();
    }
}

int findRowWithMinSum(int[,] arr){
    int index = 0, res = 0;
    for (int i = 0; i < arr.GetLength(0) ; i++){
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1) ; j++){
            sum += arr[i,j];
        }
        if (i == 0) {
            res = sum;
        }
        if (sum < res){
            res = sum;
            index = i;
        }
    }

    return index;
}

int x,y, index;
int [,] arr;
WriteLine("Введите размер массива [x,y]:");
x = int.Parse(ReadLine());
y = int.Parse(ReadLine());

arr = genArray(x,y);
WriteLine("Массив:");
printArray(arr);

index = findRowWithMinSum(arr);
WriteLine($"Строка: {index}");