void printThirdNumber(string str){
    if (str.Length < 3){
    Console.WriteLine($"{str} -> третьей цифры нет");
    return;
    }
    Console.WriteLine($"{str} -> {str[2]}");
}


Console.Clear();
Console.WriteLine("Ввод числа:");
string str = Console.ReadLine();
printThirdNumber(str);