using System;
using static System.Console;

int AnkerFunc(int m, int n){
    if (m == 0){
        return n + 1;
    } 
    return ((m != 0 && n == 0)) ? AnkerFunc(m - 1, 1) + n: AnkerFunc(m - 1, AnkerFunc(m,n - 1));
}

int m ,n, res;
WriteLine("Введите зачение m:");
m = int.Parse(ReadLine());

WriteLine("Введите зачение n:");
n = int.Parse(ReadLine());

if (m >= 0 && n >= 0){
    res = AnkerFunc(n,m);
    WriteLine($"Результат: {res}");
}