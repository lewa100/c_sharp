using System;
using static System.Console;

int[] enterArray(int n){
    int[] arr = new int[n];
    for (int i = 0; i < n ; i++){
        arr[i] = int.Parse(ReadLine()); 
    }
    return arr;
}

int countPositiveNumbers(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length ; i++){
        count += arr[i] > 0 ? 1:0;
    }
    return count;
}

WriteLine("Введите размер массива:");
int n = int.Parse(ReadLine());
int[] arr = enterArray(n);
int count = countPositiveNumbers(arr);
WriteLine($"Сумма: {count}");
