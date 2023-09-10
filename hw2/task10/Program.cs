Console.Clear();
Console.WriteLine("Ввод трехзначного числа:");
string str = Console.ReadLine();
if (str.Length < 3 || str.Length > 3){
   Console.WriteLine("Введено не трехзначное число!");
   return;
}
Console.WriteLine($"{str} -> второе число: {str[1]}");
