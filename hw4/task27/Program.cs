using System;
using static System.Console;

void getSum (string str){
    int sum = 0;
    for (int i=0; i<str.Length;i++){
        sum += (int)Char.GetNumericValue(str[i]);
    }
    WriteLine(sum);
}

WriteLine("Введите число:");
string a = ReadLine();
getSum(a);