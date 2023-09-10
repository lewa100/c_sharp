void isWeekend(int n){
    if (n < 1 || n > 7){
    Console.WriteLine($"{n} >> не день недели"); 
    }else{
        if (n > 5) {
            Console.WriteLine($"{n} >> да");
        }else{
            Console.WriteLine($"{n} >> нет");
        }  
    }
}

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели:");
int n = int.Parse(Console.ReadLine());
isWeekend(n);