using System;
using static System.Console;

void printArray(int n){
    int[] arr = new int[n];
    for (int i = 0; i < n ; i++){
        arr[i] = int.Parse(ReadLine()); 
    }
    WriteLine($"[{String.Join(',',arr)}]");
}

WriteLine("Введите размер массива:");
int n = int.Parse(ReadLine());
printArray(n);