using System;
using static System.Console;

int[] genArray(int n){
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n ; i++){
        arr[i] = rnd.Next(100,1000);
    }
    return arr;
}

int countPositiveNumbers(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length ; i++){
        count += arr[i] %2 == 0 ? 1:0;
    }
    return count;
}

WriteLine("Введите размер массива:");
int n = int.Parse(ReadLine());
int[] arr = genArray(n);
WriteLine($"Массив: {String.Join(',',arr)}");
int count = countPositiveNumbers(arr);
WriteLine($"Сумма: {count}");
