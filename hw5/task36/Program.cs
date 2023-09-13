using System;
using static System.Console;

int[] genArray(int n){
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n ; i++){
        arr[i] = rnd.Next(-10,100);
    }
    return arr;
}

int countNumbers(int[] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length ; i++){
        sum += i%2 != 0 ? arr[i]:0;
    }
    return sum;
}

WriteLine("Введите размер массива:");
int n = int.Parse(ReadLine());
int[] arr = genArray(n);
WriteLine($"Массив: {String.Join(',',arr)}");
int count = countNumbers(arr);
WriteLine($"Сумма: {count}");