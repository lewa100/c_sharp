Console.Clear();
Console.WriteLine("Enter count n:");
int n = int.Parse(Console.ReadLine());
int i = 1;
if (n > 1) {
    Console.Write($"{n} >> ");
    while (i <= n)
    {
        if (i % 2 == 0){
            if (i == 2){
                Console.Write(i); 
            }else{
                Console.Write($",{i}"); 
            }
        }
        i++;
    }
    
}else{
    Console.WriteLine($"{n} >> список пустой");
}