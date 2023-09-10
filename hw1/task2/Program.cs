Console.Clear();
Console.WriteLine("Enter a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int b = int.Parse(Console.ReadLine());
if (a > b) {
    Console.WriteLine($"max: {a}, min: {b}");
}else{
   Console.WriteLine($"max: {b}, min: {a}"); 
}
