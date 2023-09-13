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

int[,] multiMatrix(int[,] a,int[,] b){
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    Parallel.For(0, a.GetLength(0), (i) =>
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i,j] += a[i,k] * b[k,j];
            }
        }
    });
    return r;
}

int x,y, index;
int [,] arr1, arr2,matrix;
WriteLine("Введите размер массива [x,y]:");
x = int.Parse(ReadLine());
y = int.Parse(ReadLine());

arr1 = genArray(x,y);
WriteLine("\nМассив 1:");
printArray(arr1);

arr2 = genArray(x,y);
WriteLine("\nМассив 2:");
printArray(arr2);

WriteLine("\nРезультат:");
matrix = multiMatrix(arr1,arr2);
printArray(matrix);