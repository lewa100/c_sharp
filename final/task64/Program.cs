using System;
using static System.Console;

int m ,n;
WriteLine("Введите зачение m:");
m = int.Parse(ReadLine());

WriteLine("Введите зачение n:");
n = int.Parse(ReadLine());

if (m > 0 && n >0 && m < n){
    Write("Результат:");
    for (int i = 0; i <= n-m ; i++){
        Write($" {m+i}");
    }
}