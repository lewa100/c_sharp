Console.Clear();
Console.WriteLine("Enter a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter c:");
int c = int.Parse(Console.ReadLine());
int res;
if (a > b) {
    if (a > c){
        res = a;
    }else{
        res = c;
    }
}else{
   if (b > c){
        res = b;
    }else{
        res = c;
    }
}

Console.WriteLine($"max: {res}");