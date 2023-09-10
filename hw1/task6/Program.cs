Console.Clear();
Console.WriteLine("Enter a:");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0) {
    Console.WriteLine($"{a} >> да");
}else{
    Console.WriteLine($"{a} >> нет");
}