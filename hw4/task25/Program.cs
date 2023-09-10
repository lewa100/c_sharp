using System;
using static System.Console;

void myPow(int a, int b){
    int res = 1;
    for(int i = 0; i < b; i++){
        res *= a; 
    }
    WriteLine($"{a} в степени  {b} = {res}");
}

WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());

WriteLine("Введите число b:");
int b = int.Parse(Console.ReadLine());

myPow(a,b);