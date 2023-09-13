using System;
using static System.Console;

int[] genArray(int n){
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n ; i++){
        arr[i] = rnd.Next(0,30);
    }
    return arr;
}

int diffMinMax(int[] arr){
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length ; i++){
        min = arr[i] < min ? arr[i]:min;
        max = arr[i] > max ? arr[i]:max;
    }
    WriteLine($"Мин: {min}, Макс: {max}");
    return max - min;
}

WriteLine("Введите размер массива:");
int n = int.Parse(ReadLine());
int[] arr = genArray(n);
WriteLine($"Массив: {String.Join(',',arr)}");
int count = diffMinMax(arr);
WriteLine($"Сумма: {count}");