using System;
using static System.Console;

int getSum(int m,int n){
    int res = 0;
    for (int i = 0; i <= n-m ; i++){
        res += m+i;
    }
    return res;
}

int m ,n, sum;
WriteLine("Введите зачение m:");
m = int.Parse(ReadLine());

WriteLine("Введите зачение n:");
n = int.Parse(ReadLine());

if (m > 0 && n >0 && m < n){
    sum = getSum(m,n);
    WriteLine($"Сумма: {sum}");
}